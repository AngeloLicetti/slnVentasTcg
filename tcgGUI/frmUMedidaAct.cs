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
    public enum EstadoActualizar
    {
        Buscar, Actualizar
    }

    public enum EstadoEliminar
    {
        Buscar, Eliminar
    }

    public enum EstadoConsultar
    {
        Buscar, Consultar
    }
    public partial class frmUMedidaAct : Form
    {
        UMedida objUMedida;
        UMedidaNeg objUMedidaNeg;
        EstadoActualizar estado;
        public frmUMedidaAct()
        {
            InitializeComponent();
            estado = EstadoActualizar.Buscar;
            ocultar();
            objUMedidaNeg = new UMedidaNeg();
            mjeInicial();
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
            btnActualizar.Text = "Buscar";
        }
        private void visualizar()
        {
            txtCodigo.Enabled = false;
            txtNombre.Visible = true;
            txtDescripcion.Visible = true;
            btnActualizar.Text = "Actualizar";
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
                lblMje.Text = "Estos son los datos; modifique y pulse actualizar.";
            }
            else
            {
                lblMje.Text = "UMedida [" + objUMedida.UMedidaId + "] NO EXISTE.";
            }
        }

        private void mostraMjeActualizar(UMedida objUMedida)
        {
            lblMje.ForeColor = objUMedida.Estado == 99 ? Color.Green : Color.Red;

            switch (objUMedida.Estado)
            {
                case 2: //error de Nombre
                    lblMje.Text = "Ingrese Nombre de 5 y 20 caracteres.";
                    break;
                case 3: //error de Descripcion
                    lblMje.Text = "Ingrese Descripcion de 1 a 40 caracteres.";
                    break;
                
                case 99: //UMedida registrado
                    lblMje.Text = "UMedida [" + objUMedida.UMedidaId + "] actualizado satisfactoriamente.";
                    break;
                default: //
                    lblMje.Text = "==???==";
                    break;
            }
        }
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoActualizar.Buscar)
            {
                Close();
            }
            else
            {
                ocultar();
                mjeInicial();
                estado = EstadoActualizar.Buscar;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoActualizar.Buscar)
            {
                txtCodigo.Clear();
            }
            else
            {
                txtNombre.Clear();
                txtDescripcion.Clear();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (estado == EstadoActualizar.Buscar)
            {
                objUMedida = new UMedida();
                objUMedida.UMedidaId = txtCodigo.Text;
                objUMedidaNeg.LeerUMedida(objUMedida);
                mostraMjeBuscar(objUMedida);
                if (objUMedida.Estado == 99)
                {
                    cargarUMedida();
                    estado = EstadoActualizar.Actualizar;
                    visualizar();
                }
            }
            else
            {
                objUMedida = new UMedida();
                objUMedida.UMedidaId = txtCodigo.Text;
                objUMedida.Nombre = txtNombre.Text;
                objUMedida.Descripcion = txtDescripcion.Text;
                
                objUMedidaNeg.ActualizarUMedida(objUMedida);
                mostraMjeActualizar(objUMedida);
                if (objUMedida.Estado == 99)
                {
                    estado = EstadoActualizar.Buscar;
                    ocultar();
                }
            }
        }
    }
}
