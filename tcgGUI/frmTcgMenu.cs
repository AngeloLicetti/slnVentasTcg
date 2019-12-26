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
    public partial class frmTcgMenu : Form
    {
        frmTcgIngreso objIngreso;
        public frmTcgMenu(frmTcgIngreso objIngreso)
        {
            InitializeComponent();
            this.objIngreso = objIngreso;
        }

        private void cmdSistSalir_Click(object sender, EventArgs e)
        {
            Close();
            objIngreso.Show();
        }

        private void cmdRepoListUMedida_Click(object sender, EventArgs e)
        {
            (new frmUMedidaLis()).Show();
        }

        private void cmdRepoConsUMedida_Click(object sender, EventArgs e)
        {
            (new frmUMedidaCon()).Show();
        }

        private void cmdEntiUMedRegistrar_Click(object sender, EventArgs e)
        {
            (new frmUMedidaAdi()).Show();
        }

        private void cmdEntiUMedActualizar_Click(object sender, EventArgs e)
        {
            (new frmUMedidaAct()).Show();
        }

        private void cmdEntiUMedEliminar_Click(object sender, EventArgs e)
        {
            (new frmUMedidaEli()).Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new frmArticuloAdi()).Show();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new frmArticuloAct()).Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new frmArticuloEli()).Show();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new frmArticuloCon()).Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmArticuloLis()).Show();
        }
    }
}
