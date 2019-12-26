using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;
using System.Data;

public partial class wfDVentaAdi : System.Web.UI.Page
{
    DVenta objDVenta;
    wsDVenta objProxy;
    protected void Page_Load(object sender, EventArgs e)
    {
        objProxy = new wsDVenta();
        objDVenta = new DVenta();
        if (!Page.IsPostBack)
        {
            cargarVentas();
            cargarArticulos();
            mjeInicial();
        }
    }

    private void cargarVentas()
    {
        wsVenta objVentaNeg = new wsVenta();
        DataSet ds = objVentaNeg.LeerVentas();
        ddlVenta.DataSource = ds.Tables[0];
        ddlVenta.DataTextField = "VentaId";
        ddlVenta.DataValueField = "VentaId";
        ddlVenta.DataBind();
    }

    private void cargarArticulos()
    {
        wsArticulo objArticuloNeg = new wsArticulo();
        DataSet ds = objArticuloNeg.LeerArticulos();
        ddlArticulo.DataSource = ds.Tables[0];
        ddlArticulo.DataTextField = "Nombre";
        ddlArticulo.DataValueField = "ArticuloId";
        ddlArticulo.DataBind();
    }

    private void mjeInicial()
    {
        lblMje.ForeColor = System.Drawing.Color.Blue;
        lblMje.Text = "Ingrese los datos de la DVenta y pulse registrar";
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtCodigo.Text = "";
        txtCantidad.Text = "";
        txtPrecio.Text = "";
        cargarVentas();
        cargarArticulos();
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        objDVenta = new DVenta();
        objDVenta.DVentaId = txtCodigo.Text;
        try
        {
            objDVenta.Cantidad = Convert.ToInt32(txtCantidad.Text);
        }
        catch (Exception)
        {
            objDVenta.Cantidad = -1;
        }
        try
        {
            objDVenta.Precio = double.Parse(txtPrecio.Text);
        }
        catch (Exception)
        {
            objDVenta.Precio = -1;
        }
        objDVenta.VentaId = ddlVenta.SelectedValue;
        objDVenta.ArticuloId = ddlArticulo.SelectedValue;
        objDVenta = objProxy.RegistrarDVenta(objDVenta);
        mostrarMjeRegistro(objDVenta);
    }

    private void mostrarMjeRegistro(DVenta objDVenta)
    {
        lblMje.ForeColor = objDVenta.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objDVenta.Estado)
        {
            case 0: //error de código
                lblMje.Text = "Estado = 0.";
                break;
            case 1: //error de código
                lblMje.Text = "Ingrese código entre 10000 y 99999.";
                break;
            case 2: //error de cantidad
                lblMje.Text = "La cantidad debe ser un número entero no negativa.";
                break;
            case 3: //error de precio
                lblMje.Text = "El precio debe ser un número no negativo.";
                break;
            case 22: //error de duplicidad
                lblMje.Text = "DVenta " + objDVenta.DVentaId + " duplicado.";
                break;
            case 99: //Producto registrado
                lblMje.Text = "DVenta " + objDVenta.DVentaId + " registrado satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }
}