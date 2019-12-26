using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcgNegocio;

namespace tcgGUI
{
    public partial class frmUMedidaLis : Form
    {
        UMedidaNeg objUMedidaNeg;
        public frmUMedidaLis()
        {
            InitializeComponent();

            objUMedidaNeg = new UMedidaNeg();
            cargarUMedidas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarUMedidas()
        {
            DataSet dsUMedidas = objUMedidaNeg.LeerUMedidas();
            dgvUMedidas.DataSource = dsUMedidas.Tables[0];
        }
    }
}
