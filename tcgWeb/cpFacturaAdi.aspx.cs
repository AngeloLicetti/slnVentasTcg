using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tcgDominio;
using tcgNegocio;
using System.Data;

public partial class cpFacturaAdi : System.Web.UI.Page
{
    Venta objVenta;
    VentaNeg objVentaNeg;
    protected void Page_Load(object sender, EventArgs e)
    {
        objVentaNeg = new VentaNeg();
        objVenta = new Venta();
        if (!Page.IsPostBack)
        {
            cargarClientes();
            cargarTrabajadores();
            mjeInicial();
        }
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

    private void mjeInicial()
    {
        lblMje.ForeColor = System.Drawing.Color.Blue;
        lblMje.Text = "Ingrese/seleccione los datos de la Venta y pulse registrar";
    }

    protected void btnRetornar_Click(object sender, EventArgs e)
    {
        string close = @"<script type='text/javascript' >
                            window.open('','_parent','');
                            window.close();
                        </script>";
        Response.Write(close);
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtNumero.Text = "";
        txtComentario.Text = "";
        cldFecha.SelectedDate = DateTime.Now;
        cargarClientes();
        cargarTrabajadores();
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        objVenta = new Venta(txtNumero.Text, cldFecha.SelectedDate, txtComentario.Text, ddlCliente.SelectedValue, ddlTrabajador.SelectedValue);
        objVentaNeg.RegistrarVenta(objVenta);
        mostrarMjeRegistro(objVenta);
    }

    private void mostrarMjeRegistro(Venta objVenta)
    {
        lblMje.ForeColor = objVenta.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objVenta.Estado)
        {
            case 0: //error de código
                lblMje.Text = "Estado = 0.";
                break;
            case 1: //error de código
                lblMje.Text = "Ingrese código entre 11111 y 99999.";
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
                lblMje.Text = "Venta " + objVenta.VentaId + " registrada satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }
}