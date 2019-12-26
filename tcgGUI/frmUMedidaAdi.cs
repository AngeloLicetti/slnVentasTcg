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
    public partial class frmUMedidaAdi : Form
    {
        UMedida objUMedida;
        UMedidaNeg objUMedidaNeg;

        public frmUMedidaAdi()
        {
            InitializeComponent();
            objUMedidaNeg = new UMedidaNeg();
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
            txtCodigo.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objUMedida = new UMedida();
            objUMedida.UMedidaId = txtCodigo.Text;
            objUMedida.Nombre = txtNombre.Text;
            objUMedida.Descripcion = txtDescripcion.Text;
            
            objUMedidaNeg.RegistrarUMedida(objUMedida);
            mostraMjeRegistro(objUMedida);
        }
        private void mjeInicial()
        {
            lblMje.ForeColor = Color.Blue;
            lblMje.Text = "Ingrese  datos de UMedida y presione el botón Registrar";
        }

        private void mostraMjeRegistro(UMedida objUMedida)
        {
            lblMje.ForeColor = objUMedida.Estado == 99 ? Color.Green : Color.Red;

            switch (objUMedida.Estado)
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
                case 22: //error de duplicidad
                    lblMje.Text = "UMedida " + objUMedida.UMedidaId + " duplicado.";
                    break;
                case 99: //UMedida registrado
                    lblMje.Text = "UMedida " + objUMedida.UMedidaId + " registrado satisfactoriamente.";
                    break;
                default: //
                    lblMje.Text = "==???==";
                    break;
            }
        }
    }
}
