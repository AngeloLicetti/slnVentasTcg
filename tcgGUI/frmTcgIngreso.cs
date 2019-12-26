using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcgGUI
{
    public partial class frmTcgIngreso : Form
    {
        public frmTcgIngreso()
        {
            InitializeComponent();
            mjeInicial();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtClave.Text == "123")
            {
                this.Hide();
                txtUsuario.Clear();
                txtClave.Clear();

                frmTcgMenu objMenu = new frmTcgMenu(this);
                objMenu.Show();
                mjeInicial();
            }
            else
            {
                lblMje.ForeColor = Color.Red;
                lblMje.Text = "Usuario o clave incorrectos.";
            }
        }

        private void mjeInicial()
        {
            lblMje.ForeColor = Color.Blue;
            lblMje.Text = "Para ingresar escriba su usuario y clave y para salir pulse salir.";
        }
    }
}
