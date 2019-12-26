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
    public partial class frmArticuloLis : Form
    {
        ArticuloNeg objArticuloNeg;
        public frmArticuloLis()
        {
            InitializeComponent();
            objArticuloNeg = new ArticuloNeg();
            cargarArticulos();
        }

        private void cargarArticulos()
        {
            DataSet dsArticulos = objArticuloNeg.LeerArticulos();
            dgvArticulos.DataSource = dsArticulos.Tables[0];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
