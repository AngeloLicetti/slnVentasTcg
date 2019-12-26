using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;

public partial class wfClienteEli : System.Web.UI.Page
{
    wsCliente objProxy;
    Cliente objCliente;
    //EstadoEliminar estado;

    protected void Page_Load(object sender, EventArgs e)
    {
        objProxy = new wsCliente();
        objCliente = new Cliente();
        if (!Page.IsPostBack)
        {
            //estado = EstadoEliminar.Buscar;
            ocultar();
            mjeInicial();
        }
    }

    private void mjeInicial()
    {
        lblMje.ForeColor = System.Drawing.Color.Blue;
        lblMje.Text = "Ingrese  el cógido de la Cliente y presione el botón Buscar";
    }

    private void ocultar()
    {
        txtCodigo.Enabled = true;
        divOcultar.Visible = false;
        btnEliminar.Text = "Buscar";
        btnRetornar.Enabled = false;
    }

    private void visualizar()
    {
        txtCodigo.Enabled = false;
        divOcultar.Visible = true;
        btnEliminar.Text = "Eliminar";
        btnRetornar.Text = "Retornar";
        btnRetornar.Enabled = true;
    }

    private void cargarCliente()
    {
        txtCodigo.Text = objCliente.ClienteId.ToString();
        txtApellidos.Text = objCliente.Apellidos;
        txtNombres.Text = objCliente.Nombres;
        txtTelefono.Text = objCliente.Celular;
        txtDireccion.Text = objCliente.Direccion;
        txtEmail.Text = objCliente.Email;
    }

    private void mostraMjeBuscar(Cliente objCliente)
    {
        lblMje.ForeColor = objCliente.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        if (objCliente.Estado == 99)
        {
            lblMje.Text = "Estos son los datos; visualize y si está seguro que desea eliminarlo pulse Eliminar.";
        }
        else
        {
            lblMje.Text = "Cliente [" + objCliente.ClienteId + "] NO EXISTE.";
        }
    }

    protected void btnRetornar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Enabled == true)
        {
            //completar
        }
        else
        {
            ocultar();
            mjeInicial();
            //estado = EstadoEliminar.Buscar;
            btnBorrar.Enabled = true;
        }
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtCodigo.Text = "";
    }

    private void mostrarMjeELiminar(Cliente objCliente)
    {
        lblMje.ForeColor = objCliente.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objCliente.Estado)
        {
            case 1: //no existe
                lblMje.Text = "El Cliente [" + objCliente.ClienteId + "] no existe";
                break;
            case 2: //tiene hijos en DFactura
                lblMje.Text = "El Cliente [" + objCliente.ClienteId + "] tiene hijos en DVenta; NO SE PUEDE ELIMINAR";
                break;
            case 99: //Cliente eliminada
                lblMje.Text = "Cliente " + objCliente.ClienteId + " eliminado satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Enabled == true)
        {
            objCliente = new Cliente();
            objCliente.ClienteId = txtCodigo.Text;
            objCliente = objProxy.LeerCliente(objCliente);
            mostraMjeBuscar(objCliente);
            if (objCliente.Estado == 99)
            {
                cargarCliente();
                visualizar();
                btnBorrar.Enabled = false;
            }
        }
        else
        {
            objCliente = new Cliente();
            objCliente.ClienteId = txtCodigo.Text;
            objCliente = objProxy.EliminarCliente(objCliente);
            mostrarMjeELiminar(objCliente);
            if (objCliente.Estado == 99)
            {
                ocultar();
                btnBorrar.Enabled = true;
            }
        }
    }
}