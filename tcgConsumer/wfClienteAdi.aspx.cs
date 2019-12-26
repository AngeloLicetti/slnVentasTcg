using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;

public partial class wfClienteAdi : System.Web.UI.Page
{
    Cliente objCliente;
    wsCliente objProxy;
    protected void Page_Load(object sender, EventArgs e)
    {
        objProxy = new wsCliente();
        objCliente = new Cliente();
        if (!Page.IsPostBack)
        {
            mjeInicial();
        }
    }

    private void mjeInicial()
    {
        lblMje.ForeColor = System.Drawing.Color.Blue;
        lblMje.Text = "Ingrese los datos de la Cliente y pulse registrar";
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtCodigo.Text = "";
        txtApellidos.Text = "";
        txtNombres.Text = "";
        txtTelefono.Text = "";
        txtDireccion.Text = "";
        txtEmail.Text = "";
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        objCliente = new Cliente();
        objCliente.ClienteId = txtCodigo.Text;
        objCliente.Apellidos = txtApellidos.Text;
        objCliente.Nombres = txtNombres.Text;
        objCliente.Celular = txtTelefono.Text;
        objCliente.Direccion = txtDireccion.Text;
        objCliente.Email = txtEmail.Text;
        objCliente.Imagen = new byte[] { 0 };
        objCliente = objProxy.RegistrarCliente(objCliente);
        mostrarMjeRegistro(objCliente);
    }

    private void mostrarMjeRegistro(Cliente objCliente)
    {
        lblMje.ForeColor = objCliente.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objCliente.Estado)
        {
            case 0: //error de código
                lblMje.Text = "Estado = 0.";
                break;
            case 1: //error de código
                lblMje.Text = "Ingrese código entre 10000 y 99999.";
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
                lblMje.Text = "Cliente " + objCliente.ClienteId + " registrado satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }
}