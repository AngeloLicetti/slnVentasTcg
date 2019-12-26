using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.Mobile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using localhost;

public partial class wmTrabajadorAdi : System.Web.UI.MobileControls.MobilePage
{
    Trabajador objTrabajador;
    wsTrabajador objProxy;
    protected void Page_Load(object sender, EventArgs e)
    {
        objProxy = new wsTrabajador();
        objTrabajador = new Trabajador();
        if (!Page.IsPostBack)
        {
            mjeInicial();
        }
    }

    private void mjeInicial()
    {
        lblMje.ForeColor = System.Drawing.Color.Blue;
        lblMje.Text = "Ingrese los datos de la Trabajador y pulse registrar";
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtCodigo.Text = "";
        txtApellidos.Text = "";
        txtNombres.Text = "";
        txtCargo.Text = "";
        txtDni.Text = "";
        txtTelefono.Text = "";
        txtDireccion.Text = "";
        txtEmail.Text = "";
    }


    protected void btnRetornar_Click(object sender, EventArgs e)
    {
        this.RedirectToMobilePage("Default.aspx");
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        objTrabajador = new Trabajador();
        objTrabajador.TrabajadorId = txtCodigo.Text;
        objTrabajador.Apellidos = txtApellidos.Text;
        objTrabajador.Nombres = txtNombres.Text;
        objTrabajador.Cargo = txtCargo.Text;
        objTrabajador.Dni = txtDni.Text;
        objTrabajador.Celular = txtTelefono.Text;
        objTrabajador.Direccion = txtDireccion.Text;
        objTrabajador.Email = txtEmail.Text;
        objTrabajador.Imagen = new byte[] { 0 };
        objTrabajador = objProxy.RegistrarTrabajador(objTrabajador);
        mostrarMjeRegistro(objTrabajador);
    }

    private void mostrarMjeRegistro(Trabajador objTrabajador)
    {
        lblMje.ForeColor = objTrabajador.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objTrabajador.Estado)
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

            case 4: //error de cargo
                lblMje.Text = "Ingrese cargo entre 2 y 30 caracteres.";
                break;
            case 5: //error de DNI
                lblMje.Text = "Ingrese DNI de 8 dígitos significattivos";
                break;
            case 6: //error de telefono
                lblMje.Text = "Ingrese teléfono de 9 dígitos significattivos";
                break;
            case 7: //error de direccion
                lblMje.Text = "Ingrese direccion entre 2 y 50 caracteres";
                break;
            case 8: //error de email
                lblMje.Text = "Ingrese email VÁLIDO. Debe tener entre 2 y 40 caracteres.";
                break;
            case 22: //error de duplicidad
                lblMje.Text = "Trabajador " + objTrabajador.TrabajadorId + " duplicado.";
                break;
            case 99: //Producto registrado
                lblMje.Text = "Trabajador " + objTrabajador.TrabajadorId + " registrado satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }
}