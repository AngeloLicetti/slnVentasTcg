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
    public partial class frmArticuloAdi : Form
    {
        Articulo objArticulo;
        ArticuloNeg objArticuloNeg;
        MemoryStream ms;

        public frmArticuloAdi()
        {
            InitializeComponent();
            objArticuloNeg = new ArticuloNeg();
            ms = new MemoryStream();
            mjeInicial();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ((TextBox)ctr).Clear();
                }
            }
            //borra imagen:
            pbImagen.Image = null;

            txtCodigo.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
                mostraMjeRegistro(objArticulo);
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
                mostraMjeRegistro(objArticulo);
                return;
            }
            //leer imagen:
            try
            {
                pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
                objArticulo.Imagen = ms.ToArray();
            }
            catch (Exception)
            {
                objArticulo.Estado = 6;
                mostraMjeRegistro(objArticulo);
                return;
            }
            
            objArticulo.UMedidaId= txtUMedidaId.Text;
            objArticuloNeg.RegistrarArticulo(objArticulo);
            mostraMjeRegistro(objArticulo);
        }
        private void mjeInicial()
        {
            lblMje.ForeColor = Color.Blue;
            lblMje.Text = "Ingrese  datos de Articulo y presione el botón Registrar";
        }

        private void mostraMjeRegistro(Articulo objArticulo)
        {
            lblMje.ForeColor = objArticulo.Estado == 99 ? Color.Green : Color.Red;

            switch (objArticulo.Estado)
            {
                case 1: //error de código
                    lblMje.Text = "Ingrese código entre 11111 y 99999.";
                    break;
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
                case 22: //error de duplicidad
                    lblMje.Text = "Articulo " + objArticulo.ArticuloId + " duplicado.";
                    break;
                case 99: //Articulo registrado
                    lblMje.Text = "Articulo " + objArticulo.ArticuloId + " registrado satisfactoriamente.";
                    break;
                default: //
                    lblMje.Text = "==???==";
                    break;
            }
        }

        private void btnCargarImagen_Click_1(object sender, EventArgs e)
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
