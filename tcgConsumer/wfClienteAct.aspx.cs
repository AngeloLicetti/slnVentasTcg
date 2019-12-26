using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;

public partial class wfClienteAct : System.Web.UI.Page
{
    wsCliente objProxy;
    Cliente objCliente;

    protected void Page_Load(object sender, EventArgs e)
    {
        objProxy = new wsCliente();
        objCliente = new Cliente();
        if (!Page.IsPostBack)
        {
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
        btnActualizar.Text = "Buscar";
        btnRetornar.Enabled = false;
    }

    private void visualizar()
    {
        txtCodigo.Enabled = false;
        divOcultar.Visible = true;
        btnActualizar.Text = "Actualizar";
        btnRetornar.Enabled = true;
    }

    private void cargarCliente()
    {
        txtCodigo.Text = objCliente.ClienteId;
        txtApellidos.Text = objCliente.Apellidos;
        txtNombres.Text = objCliente.Nombres;
        txtTelefono.Text = objCliente.Celular.ToString();
        txtDireccion.Text = objCliente.Direccion;
        txtEmail.Text = objCliente.Email;
    }

    private void mostraMjeBuscar(Cliente objCliente)
    {
        lblMje.ForeColor = objCliente.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        if (objCliente.Estado == 99)
        {
            lblMje.Text = "Estos son los datos; modifique y pulse actualizar.";
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
        }
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Enabled == true)
        {
            txtCodigo.Text = "";
        }
        else
        {
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
        }
    }

    private void mostrarMjeActualizar(Cliente objCliente)
    {
        lblMje.ForeColor = objCliente.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objCliente.Estado)
        {

            case 0: //error de código
                lblMje.Text = "Estado = 0.";
                break;
            case 1: //error de código
                lblMje.Text = "Cliente [" + objCliente.ClienteId + "] NO EXISTE.";
                break;
            case 2: //error de apellidos
                lblMje.Text = "Ingrese apellidos entre 2 y 30 caracteres.";
                break;
            case 3: //error de nombres
                lblMje.Text = "Ingrese nombres  entre 2 y 30 caracteres.";
                break;
            case 4: //error de telefono
                lblMje.Text = "Ingrese teléfono de 9 dígitos significattivos";
                break;
            case 5: //error de direccion
                lblMje.Text = "Ingrese direccion entre 2 y 50 caracteres";
                break;
            case 6: //error de email
                lblMje.Text = "Ingrese email VÁLIDO. Debe tener entre 2 y 40 caracteres.";
                break;
            case 22: //error de duplicidad
                lblMje.Text = "Cliente " + objCliente.ClienteId + " duplicado.";
                break;
            case 99: //Producto registrado
                lblMje.Text = "Cliente " + objCliente.ClienteId + " actualizado satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }

    protected void btnActualizar_Click(object sender, EventArgs e)
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
            }
        }
        else
        {
            objCliente = new Cliente();
            objCliente.ClienteId = txtCodigo.Text;
            objCliente.Apellidos = txtApellidos.Text;
            objCliente.Nombres = txtNombres.Text;
            objCliente.Celular = txtTelefono.Text;
            objCliente.Direccion = txtDireccion.Text;
            objCliente.Email = txtEmail.Text;
            objCliente.Imagen = new byte[] { 0 };

            objCliente = objProxy.ActualizarCliente(objCliente);
            mostrarMjeActualizar(objCliente);
            if (objCliente.Estado == 99)
            {
                ocultar();
            }
        }
    }
}