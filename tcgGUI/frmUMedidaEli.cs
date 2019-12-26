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
    public partial class frmUMedidaEli : Form
    {
        EstadoEliminar estado;
        UMedida objUMedida;
        UMedidaNeg objUMedidaNeg;
        public frmUMedidaEli()
        {
            InitializeComponent();
            estado = EstadoEliminar.Buscar;
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
            btnEliminar.Text = "Buscar";
        }
        private void visualizar()
        {
            txtCodigo.Enabled = false;
            txtNombre.Visible = true;
            txtDescripcion.Visible = true;
            btnEliminar.Text = "Eliminar";
        }

        private void cargarUMedida()
        {
            txtDescripcion.Text = objUMedida.Descripcion;
            txtNombre.Text = objUMedida.Nombre;
            txtDescripcion.Text = objUMedida.Descripcion;
        }

        private void mostraMjeBuscar(UMedida objUMedida)
        {
            lblMje.ForeColor = objUMedida.Estado == 99 ? Color.Green : Color.Red;
            if (objUMedida.Estado == 99)
            {
                lblMje.Text = "Estos son los datos; visualize y si está seguro que desea eliminarlo pulse Eliminar.";
            }
            else
            {
                lblMje.Text = "UMedida [" + objUMedida.UMedidaId + "] NO EXISTE.";
            }
        }

        private void mostraMjeEliminar(UMedida objUMedida)
        {
            lblMje.ForeColor = objUMedida.Estado == 99 ? Color.Green : Color.Red;

            switch (objUMedida.Estado)
            {
                case 1: //el UMedida no existe
                    lblMje.Text = "El UMedida [" + objUMedida.UMedidaId + "] NO EXISTE.";
                    break;
                case 2: //el UMedida tiene HIJOS en ARTICULO
                    lblMje.Text = "El UMedida [" + objUMedida.UMedidaId + "] tiene hijos en ARTICULO; NO SE PUEDE ELIMINAR.";
                    break;
                case 99: //UMedida registrado
                    lblMje.Text = "UMedida [" + objUMedida.UMedidaId + "] eliminado satisfactoriamente.";
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
                objUMedida = new UMedida();
                objUMedida.UMedidaId = txtCodigo.Text;
                objUMedidaNeg.LeerUMedida(objUMedida);
                mostraMjeBuscar(objUMedida);
                if (objUMedida.Estado == 99)
                {
                    cargarUMedida();
                    estado = EstadoEliminar.Eliminar;
                    visualizar();
                    btnBorrar.Enabled = false;
                }
            }
            else
            {
                objUMedida = new UMedida();
                objUMedida.UMedidaId = txtCodigo.Text;
                objUMedidaNeg.EliminarUMedida(objUMedida);
                mostraMjeEliminar(objUMedida);
                if (objUMedida.Estado == 99)
                {
                    estado = EstadoEliminar.Buscar;
                    btnBorrar.Enabled = true;
                    ocultar();
                }
            }
        }
    }
}
