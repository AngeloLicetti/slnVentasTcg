using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcgDominio;
using tcgNegocio;

namespace tcgGUI
{
    public partial class frmArticuloAct : Form
    {
        Articulo objArticulo;
        ArticuloNeg objArticuloNeg;
        MemoryStream ms;
        EstadoActualizar estado;
        public frmArticuloAct()
        {
            InitializeComponent();
            estado = EstadoActualizar.Buscar;
            ocultar();
            objArticuloNeg = new ArticuloNeg();
            ms = new MemoryStream();
            mjeInicial();
        }

        private void mjeInicial()
        {
            lblMje.ForeColor = Color.Blue;
            lblMje.Text = "Ingrese  el cógido del Articulo y presione el botón Buscar";
        }

        private void ocultar()
        {
            txtCodigo.Enabled = true;
            txtNombre.Visible = false;
            txtDescripcion.Visible = false;
            txtCantidad.Visible = false;
            txtPrecio.Visible = false;
            //ocultar imagen y boton para cargar:
            btnCargarImagen.Visible = false;
            pbImagen.Visible=false;

            txtUMedidaId.Visible = false;
            btnActualizar.Text = "Buscar";
        }
        private void visualizar()
        {
            txtCodigo.Enabled = false;
            txtNombre.Visible = true;
            txtDescripcion.Visible = true;
            txtCantidad.Visible = true;
            txtPrecio.Visible = true;
            //mostrar imagen y boton para cargar:
            btnCargarImagen.Visible = true;
            pbImagen.Visible = true;

            txtUMedidaId.Visible = true;
            btnActualizar.Text = "Actualizar";
        }

        private void cargarArticulo()
        {
            txtNombre.Text = objArticulo.ArticuloId;
            txtDescripcion.Text = objArticulo.Descripcion;
            txtCantidad.Text = Convert.ToString(objArticulo.Cantidad);
            txtPrecio.Text = Convert.ToString(objArticulo.Precio);
            //cargar imagen:
            try
            {
                ms = new MemoryStream(objArticulo.Imagen);
                pbImagen.Image = Image.FromStream(ms);
            }
            catch
            {
                objArticulo.Estado = 6;
            }
            txtUMedidaId.Text = objArticulo.UMedidaId;
        }

        private void mostraMjeBuscar(Articulo objArticulo)
        {
            lblMje.ForeColor = objArticulo.Estado == 99 ? Color.Green : Color.Red;
            if (objArticulo.Estado == 99)
            {
                lblMje.Text = "Estos son los datos; modifique y pulse actualizar.";
            }
            else if(objArticulo.Estado == 6)
            {
                lblMje.Text = "Ha ocurrido un error al cargar la imagen.";
            }
            else
            {
                lblMje.Text = "Articulo [" + objArticulo.ArticuloId + "] NO EXISTE.";
            }
        }

        private void mostraMjeActualizar(Articulo objArticulo)
        {
            lblMje.ForeColor = objArticulo.Estado == 99 ? Color.Green : Color.Red;

            switch (objArticulo.Estado)
            {
                case 2: //error de Nombre
                    lblMje.Text = "Ingrese Nombre de 5 y 20 caracteres.";
                    break;
                case 3: //error de Descripcion
                    lblMje.Text = "Ingrese Descripcion de 1 a 40 caracteres.";
                    break;
                case 4: //error de Cantidad
                    lblMje.Text = "La cantidad debe ser un número entero positivo.";
                    break;
                case 5: //error de Precio
                    lblMje.Text = "El precio debe ser un número mayor que 0.";
                    break;
                case 6: //error de Imagen
                    lblMje.Text = "No ha cargado una imagen aceptable";
                    break;
                case 7: //error de UMedidaId
                    lblMje.Text = "La UMedida: [" + objArticulo.UMedidaId + "] no existe";
                    break;
                case 99: //Articulo registrado
                    lblMje.Text = "Articulo [" + objArticulo.ArticuloId + "] actualizado satisfactoriamente.";
                    break;
                default: //
                    lblMje.Text = "==???==";
                    break;
            }
        }
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoActualizar.Buscar)
            {
                Close();
            }
            else
            {
                ocultar();
                mjeInicial();
                estado = EstadoActualizar.Buscar;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoActualizar.Buscar)
            {
                txtCodigo.Clear();
            }
            else
            {
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
                txtUMedidaId.Clear();
                //limpiar imagen:
                pbImagen.Image = null;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoActualizar.Buscar)
            {
                objArticulo = new Articulo();
                objArticulo.ArticuloId = txtCodigo.Text;
                objArticuloNeg.LeerArticulo(objArticulo);
                mostraMjeBuscar(objArticulo);
                if (objArticulo.Estado == 99)
                {
                    visualizar();
                    cargarArticulo();
                    estado = EstadoActualizar.Actualizar;
                }
            }
            else
            {
                objArticulo = new Articulo();
                objArticulo.ArticuloId = txtCodigo.Text;
                objArticulo.Nombre = txtNombre.Text;
                objArticulo.Descripcion = txtDescripcion.Text;
                try
                {
                    if (txtCantidad.Text == "")
                    {
                        throw new Exception();
                    }
                    int cantidad = int.Parse(txtCantidad.Text);
                    objArticulo.Cantidad = cantidad;
                }
                catch (Exception)
                {
                    objArticulo.Estado = 4;
                    mostraMjeActualizar(objArticulo);
                    return;
                }
                try
                {
                    if (txtPrecio.Text == "")
                    {
                        throw new Exception();
                    }
                    double precio = double.Parse(txtPrecio.Text);
                    objArticulo.Precio = precio;
                }
                catch (Exception)
                {
                    objArticulo.Estado = 5;
                    mostraMjeActualizar(objArticulo);
                    return;
                }
                objArticulo.UMedidaId = txtUMedidaId.Text;
                //leer imagen:
                ms = new MemoryStream();
                try
                {
                    pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
                    objArticulo.Imagen = ms.ToArray();
                }
                catch (Exception)
                {
                    objArticulo.Estado = 6;
                    mostraMjeActualizar(objArticulo);
                    return;
                }

                objArticuloNeg.ActualizarArticulo(objArticulo);
                mostraMjeActualizar(objArticulo);
                if (objArticulo.Estado == 99)
                {
                    estado = EstadoActualizar.Buscar;
                    ocultar();
                }
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Load(ofd.FileName);
            }
        }
    }
}
