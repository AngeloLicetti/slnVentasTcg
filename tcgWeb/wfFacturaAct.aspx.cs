using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tcgDominio;
using tcgNegocio;
using System.Data;


public enum EstadoActualizar
{
    Buscar, Actualizar
}

public partial class wfFacturaAct : System.Web.UI.Page
{
    Venta objVenta;
    VentaNeg objVentaNeg;
    EstadoActualizar estado;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        objVentaNeg = new VentaNeg();
        objVenta = new Venta();
        if (!Page.IsPostBack)
        {
            estado = EstadoActualizar.Buscar;
            ocultar();
            cargarClientes();
            cargarTrabajadores();
            mjeInicial();
        }
    }

    private void mjeInicial()
    {
        lblMje.ForeColor = System.Drawing.Color.Blue;
        lblMje.Text = "Ingrese  el cógido de la Venta y presione el botón Buscar";
    }

    private void cargarClientes()
    {
        ClienteNeg objClienteNeg = new ClienteNeg();
        DataSet ds = objClienteNeg.LeerClientes();
        ddlCliente.DataSource = ds.Tables[0];
        ddlCliente.DataTextField = "Nombres";
        ddlCliente.DataValueField = "ClienteId";
        ddlCliente.DataBind();
    }

    private void cargarTrabajadores()
    {
        TrabajadorNeg objTrabajadorNeg = new TrabajadorNeg();
        DataSet ds = objTrabajadorNeg.LeerTrabajadors();
        ddlTrabajador.DataSource = ds.Tables[0];
        ddlTrabajador.DataTextField = "Nombres";
        ddlTrabajador.DataValueField = "TrabajadorId";
        ddlTrabajador.DataBind();
    }

    private void ocultar()
    {
        txtNumero.Enabled = true;
        divOcultar.Visible = false;
        btnActualizar.Text = "Buscar";
    }

    private void visualizar()
    {
        txtNumero.Enabled = false;
        divOcultar.Visible = true;
        btnActualizar.Text = "Actualizar";
    }

    private void cargarVenta()
    {
        txtNumero.Text = objVenta.VentaId.ToString();
        txtComentario.Text = objVenta.Comentario;
        cldFecha.SelectedDate = objVenta.Fecha.Date;
        ddlCliente.ClearSelection();
        ddlCliente.Items.FindByValue(objVenta.ClienteId).Selected = true;
        ddlTrabajador.ClearSelection();
        ddlTrabajador.Items.FindByValue(objVenta.TrabajadorId).Selected = true;
    }

    private void mostraMjeBuscar(Venta objVenta)
    {
        lblMje.ForeColor = objVenta.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        if (objVenta.Estado == 99)
        {
            lblMje.Text = "Estos son los datos; modifique y pulse actualizar.";
        }
        else
        {
            lblMje.Text = "Venta [" + objVenta.VentaId + "] NO EXISTE.";
        }
    }

    protected void btnRetornar_Click(object sender, EventArgs e)
    {
        if (txtNumero.Enabled==true)
        {
            //completar
            Response.Redirect("WfMenu.aspx");
        }
        else
        {
            ocultar();
            mjeInicial();
            estado = EstadoActualizar.Buscar;
        }
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        if (txtNumero.Enabled==true)
        {
            txtNumero.Text = "";
        }
        else
        {
            txtComentario.Text = "";
            cldFecha.SelectedDate = DateTime.Now.Date;
            cargarClientes();
            cargarTrabajadores();
        }
    }

    private void mostrarMjeActualizar(Venta objVenta)
    {
        lblMje.ForeColor = objVenta.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objVenta.Estado)
        {
            case 0: //error de código
                lblMje.Text = "Estado = 0.";
                break;
            case 2: //error de fecha
                lblMje.Text = "Ingrese fecha adecuada.";
                break;
            case 3: //error de comentario
                lblMje.Text = "Ingrese comentario debe tener 1 a 100 caracteres.";
                break;
            case 4: //error de cliente
                lblMje.Text = "El cliente [" + objVenta.ClienteId + "] no existe";
                break;
            case 5: //error de trabajador
                lblMje.Text = "El trabajador [" + objVenta.TrabajadorId + "] no existe";
                break;
            case 22: //error de duplicidad
                lblMje.Text = "Venta " + objVenta.VentaId + " duplicada.";
                break;
            case 99: //Producto registrado
                lblMje.Text = "Venta " + objVenta.VentaId + " actualizada satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }

    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        if (txtNumero.Enabled==true)
        {
            objVenta = new Venta();
            objVenta.VentaId = txtNumero.Text;
            objVentaNeg.LeerVenta(objVenta);
            mostraMjeBuscar(objVenta);
            if (objVenta.Estado == 99)
            {
                cargarVenta();
                visualizar();
                estado = EstadoActualizar.Actualizar;
            }
        }
        else
        {
            objVenta = new Venta(txtNumero.Text, cldFecha.SelectedDate, txtComentario.Text, ddlCliente.SelectedValue, ddlTrabajador.SelectedValue);
            objVentaNeg.ActualizarVenta(objVenta);
            mostrarMjeActualizar(objVenta);
            if (objVenta.Estado == 99)
            {
                estado = EstadoActualizar.Buscar;
                ocultar();
            }
        }
    }
}