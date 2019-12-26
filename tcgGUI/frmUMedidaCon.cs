using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcgDominio;
using tcgNegocio;

namespace tcgGUI
{
    public partial class frmUMedidaCon : Form
    {
        EstadoConsultar estado;
        UMedida objUMedida;
        UMedidaNeg objUMedidaNeg;
        public frmUMedidaCon()
        {
            InitializeComponent();
            estado = EstadoConsultar.Buscar;
            ocultar();
            objUMedidaNeg = new UMedidaNeg();
            mjeInicial();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
        }

        private void mjeInicial()
        {
            lblMje.ForeColor = Color.Blue;
            lblMje.Text = "Ingrese  el cógido del UMedida y presione el botón Buscar";
        }
        private void ocultar()
        {
            txtCodigo.Enabled = true;
            txtNombre.Visible = false;
            txtDescripcion.Visible = false;
            btnConsultar.Text = "Buscar";
        }
        private void visualizar()
        {
            txtCodigo.Enabled = false;
            txtNombre.Visible = true;
            txtDescripcion.Visible = true;
            btnConsultar.Text = "Consultar";
        }

        private void cargarUMedida()
        {
            txtNombre.Text = objUMedida.Nombre;
            txtDescripcion.Text = objUMedida.Descripcion;
        }

        private void mostraMjeBuscar(UMedida objUMedida)
        {
            lblMje.ForeColor = objUMedida.Estado == 99 ? Color.Green : Color.Red;
            if (objUMedida.Estado == 99)
            {
                lblMje.Text = "Estos son los datos; visualize y cuando termine pulse retornar.";
            }
            else
            {
                lblMje.Text = "UMedida [" + objUMedida.UMedidaId + "] NO EXISTE.";
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
                objUMedida = new UMedida();
                objUMedida.UMedidaId = txtCodigo.Text;
                objUMedidaNeg.LeerUMedida(objUMedida);
                mostraMjeBuscar(objUMedida);
                if (objUMedida.Estado == 99)
                {
                    cargarUMedida();
                    estado = EstadoConsultar.Consultar;
                    visualizar();
                    btnConsultar.Enabled = false;
                    btnBorrar.Enabled = false;
                }
            }
        }
    }
}
