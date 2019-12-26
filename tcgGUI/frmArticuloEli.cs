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
    public partial class frmArticuloEli : Form
    {
        EstadoEliminar estado;
        Articulo objArticulo;
        ArticuloNeg objArticuloNeg;
        public frmArticuloEli()
        {
            InitializeComponent();
            estado = EstadoEliminar.Buscar;
            ocultar();
            objArticuloNeg = new ArticuloNeg();
            mjeInicial();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
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
            //ocultar imagen:
            pbImagen.Visible = false;
            txtUMedidaId.Visible = false;
            btnEliminar.Text = "Buscar";
        }
        private void visualizar()
        {
            txtCodigo.Enabled = false;
            txtNombre.Visible = true;
            txtDescripcion.Visible = true;
            txtCantidad.Visible = true;
            txtPrecio.Visible = true;
            //mostrar imagen:
            pbImagen.Visible = true;
            txtUMedidaId.Visible = true;
            btnEliminar.Text = "Eliminar";
        }

        private void cargarArticulo()
        {
            txtNombre.Text = objArticulo.Nombre;
            txtDescripcion.Text = objArticulo.Descripcion;
            txtCantidad.Text = Convert.ToString(objArticulo.Cantidad);
            txtPrecio.Text = Convert.ToString(objArticulo.Precio);
            //cargar imagen:
            try
            {
                MemoryStream ms = new MemoryStream(objArticulo.Imagen);
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
                lblMje.Text = "Estos son los datos; visualize y si está seguro que desea eliminarlo pulse Eliminar.";
            }
            else if (objArticulo.Estado == 6)
            {
                lblMje.Text = "Ha ocurrido un error al cargar la imagen.";
            }
            else
            {
                lblMje.Text = "Articulo [" + objArticulo.ArticuloId + "] NO EXISTE.";
            }
        }

        private void mostraMjeEliminar(Articulo objArticulo)
        {
            lblMje.ForeColor = objArticulo.Estado == 99 ? Color.Green : Color.Red;

            switch (objArticulo.Estado)
            {
                case 2: //el Articulo tiene HIJOS en DVENTA
                    lblMje.Text = "El Articulo [" + objArticulo.ArticuloId + "] tiene hijos en DVENTA; NO SE PUEDE ELIMINAR.";
                    break;
                case 99: //Articulo registrado
                    lblMje.Text = "Articulo [" + objArticulo.ArticuloId + "] eliminado satisfactoriamente.";
                    break;
                default: //
                    lblMje.Text = "==???==";
                    break;
            }
        }
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoEliminar.Buscar)
            {
                Close();
            }
            else
            {
                ocultar();
                mjeInicial();
                estado = EstadoEliminar.Buscar;
                btnBorrar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoEliminar.Buscar)
            {
                objArticulo = new Articulo();
                objArticulo.ArticuloId = txtCodigo.Text;
                objArticuloNeg.LeerArticulo(objArticulo);
                mostraMjeBuscar(objArticulo);
                if (objArticulo.Estado == 99)
                {
                    cargarArticulo();
                    estado = EstadoEliminar.Eliminar;
                    visualizar();
                    btnBorrar.Enabled = false;
                }
            }
            else
            {
                objArticulo = new Articulo();
                objArticulo.ArticuloId = txtCodigo.Text;
                objArticuloNeg.EliminarArticulo(objArticulo);
                mostraMjeEliminar(objArticulo);
                if (objArticulo.Estado == 99)
                {
                    estado = EstadoEliminar.Buscar;
                    btnBorrar.Enabled = true;
                    ocultar();
                }
            }
        }
    }
}
