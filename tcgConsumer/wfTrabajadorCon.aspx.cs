using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;

public partial class wfTrabajadorCon : System.Web.UI.Page
{
    wsTrabajador objProxy;
    Trabajador objTrabajador;
    //EstadoEliminar estado;

    protected void Page_Load(object sender, EventArgs e)
    {
        objProxy = new wsTrabajador();
        objTrabajador = new Trabajador();
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
        lblMje.Text = "Ingrese  el cógido de la Trabajador y presione el botón Buscar";
    }

    private void ocultar()
    {
        txtCodigo.Enabled = true;
        divOcultar.Visible = false;
        btnConsultar.Enabled = true;
        btnRetornar.Enabled = false;
    }

    private void visualizar()
    {
        txtCodigo.Enabled = false;
        divOcultar.Visible = true;
        btnConsultar.Enabled = false;
        btnRetornar.Text = "Retornar";
        btnRetornar.Enabled = true;
    }

    private void cargarTrabajador()
    {
        txtCodigo.Text = objTrabajador.TrabajadorId.ToString();
        txtApellidos.Text = objTrabajador.Apellidos;
        txtNombres.Text = objTrabajador.Nombres;
        txtCargo.Text = objTrabajador.Cargo;
        txtDni.Text = objTrabajador.Dni;
        txtTelefono.Text = objTrabajador.Celular;
        txtDireccion.Text = objTrabajador.Direccion;
        txtEmail.Text = objTrabajador.Email;
    }

    private void mostraMjeBuscar(Trabajador objTrabajador)
    {
        lblMje.ForeColor = objTrabajador.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        if (objTrabajador.Estado == 99)
        {
            lblMje.Text = "Estos son los datos; visualize y pulse Retornar para retornar.";
        }
        else
        {
            lblMje.Text = "Trabajador [" + objTrabajador.TrabajadorId + "] NO EXISTE.";
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

    private void mostrarMjeELiminar(Trabajador objTrabajador)
    {
        lblMje.ForeColor = objTrabajador.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objTrabajador.Estado)
        {
            case 1: //no existe
                lblMje.Text = "El Trabajador [" + objTrabajador.TrabajadorId + "] no existe";
                break;
            case 2: //tiene hijos en DFactura
                lblMje.Text = "El Trabajador [" + objTrabajador.TrabajadorId + "] tiene hijos en DFactura; NO SE PUEDE ELIMINAR";
                break;
            case 99: //Trabajador eliminada
                lblMje.Text = "Trabajador " + objTrabajador.TrabajadorId + " eliminado satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Enabled == true)
        {
            objTrabajador = new Trabajador();
            objTrabajador.TrabajadorId = txtCodigo.Text;
            objTrabajador = objProxy.LeerTrabajador(objTrabajador);
            mostraMjeBuscar(objTrabajador);
            if (objTrabajador.Estado == 99)
            {
                cargarTrabajador();
                visualizar();
                btnBorrar.Enabled = false;
            }
        }
        else
        {
            objTrabajador = new Trabajador();
            objTrabajador.TrabajadorId = txtCodigo.Text;
            objTrabajador = objProxy.EliminarTrabajador(objTrabajador);
            mostrarMjeELiminar(objTrabajador);
            if (objTrabajador.Estado == 99)
            {
                ocultar();
                btnBorrar.Enabled = true;
            }
        }
    }
}