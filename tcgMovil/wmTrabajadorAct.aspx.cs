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


public partial class wmTrabajadorAct : System.Web.UI.MobileControls.MobilePage
{
    int estado;
    wsTrabajador objProxy;
    Trabajador objTrabajador;

    protected void Page_Load(object sender, EventArgs e)
    {
        objProxy = new wsTrabajador();
        objTrabajador = new Trabajador();
        if (!Page.IsPostBack)
        {
            ocultar();
            mjeInicial();
            estado = 0;
        }
    }

    private void mjeInicial()
    {
        lblMje.ForeColor = System.Drawing.Color.Blue;
        lblMje.Text = "Ingrese  el cógido de la Trabajador y presione el botón Buscar";
    }
    private void ocultar()
    {
        estado = 0;
        txtCodigo.Visible = true;
        lblCod.Text = "";
        lblCod.Visible = false;
        divOcultar.Visible = false;
        btnActualizar.Text = "Buscar";
    }

    private void visualizar()
    {
        estado = 1;
        txtCodigo.Visible = false;
        lblCod.Text = txtCodigo.Text;
        lblCod.Visible = true;
        divOcultar.Visible = true;
        btnActualizar.Text = "Actualizar";
    }

    private void cargarTrabajador()
    {
        txtCodigo.Text = objTrabajador.TrabajadorId;
        txtApellidos.Text = objTrabajador.Apellidos;
        txtNombres.Text = objTrabajador.Nombres;
        txtCargo.Text = objTrabajador.Cargo;
        txtDni.Text = objTrabajador.Dni;
        txtTelefono.Text = objTrabajador.Celular.ToString();
        txtDireccion.Text = objTrabajador.Direccion;
        txtEmail.Text = objTrabajador.Email;
    }

    private void mostraMjeBuscar(Trabajador objTrabajador)
    {
        lblMje.ForeColor = objTrabajador.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        if (objTrabajador.Estado == 99)
        {
            lblMje.Text = "Estos son los datos; modifique y pulse actualizar.";
        }
        else
        {
            lblMje.Text = "Trabajador [" + objTrabajador.TrabajadorId + "] NO EXISTE.";
        }
    }

    protected void btnRetornar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Visible == true)
        {
            this.RedirectToMobilePage("Default.aspx");
        }
        else
        {
            ocultar();
            mjeInicial();
        }
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Visible == true)
        {
            txtCodigo.Text = "";
        }
        else
        {
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtCargo.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
        }
    }

    private void mostrarMjeActualizar(Trabajador objTrabajador)
    {
        lblMje.ForeColor = objTrabajador.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objTrabajador.Estado)
        {

            case 0: //error de código
                lblMje.Text = "Estado = 0.";
                break;
            case 1: //error de código
                lblMje.Text = "Trabajador [" + objTrabajador.TrabajadorId + "] NO EXISTE.";
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
                lblMje.Text = "Trabajador " + objTrabajador.TrabajadorId + " actualizado satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }

    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Visible == true)
        {
            objTrabajador = new Trabajador();
            objTrabajador.TrabajadorId = txtCodigo.Text;
            objTrabajador = objProxy.LeerTrabajador(objTrabajador);
            mostraMjeBuscar(objTrabajador);
            if (objTrabajador.Estado == 99)
            {
                cargarTrabajador();
                visualizar();
            }
        }
        else
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

            objTrabajador = objProxy.ActualizarTrabajador(objTrabajador);
            mostrarMjeActualizar(objTrabajador);
            if (objTrabajador.Estado == 99)
            {
                ocultar();
            }
        }
    }
}