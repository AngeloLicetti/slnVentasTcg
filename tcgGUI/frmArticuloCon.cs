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
    public partial class frmArticuloCon : Form
    {
        EstadoConsultar estado;
        Articulo objArticulo;
        ArticuloNeg objArticuloNeg;
        public frmArticuloCon()
        {
            InitializeComponent();
            estado = EstadoConsultar.Buscar;
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
            btnConsultar.Text = "Buscar";
        }
        private void visualizar()
        {
            txtCodigo.Enabled = false;
            txtNombre.Visible = true;
            txtDescripcion.Visible = true;
            txtCantidad.Visible = true;
            txtPrecio.Visible = true;
            //visualizar imagen:
            pbImagen.Visible = true;

            txtUMedidaId.Visible = true;
            btnConsultar.Text = "Consultar";
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
                lblMje.Text = "Estos son los datos; visualize y cuando termine pulse retornar.";
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

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoConsultar.Buscar)
            {
                Close();
            }
            else
            {
                ocultar();
                mjeInicial();
                estado = EstadoConsultar.Buscar;
                btnConsultar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoConsultar.Buscar)
            {
                objArticulo = new Articulo();
                objArticulo.ArticuloId = txtCodigo.Text;
                objArticuloNeg.LeerArticulo(objArticulo);
                mostraMjeBuscar(objArticulo);
                if (objArticulo.Estado == 99)
                {
                    cargarArticulo();
                    estado = EstadoConsultar.Consultar;
                    visualizar();
                    btnConsultar.Enabled = false;
                    btnBorrar.Enabled = false;
                }
            }
        }
    }
}
