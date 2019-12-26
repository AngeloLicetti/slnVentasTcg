using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;
using System.Data;

public partial class wfDVentaEli : System.Web.UI.Page
{
    wsDVenta objProxy;
    DVenta objDVenta;

    protected void Page_Load(object sender, EventArgs e)
    {
        objProxy = new wsDVenta();
        objDVenta = new DVenta();
        if (!Page.IsPostBack)
        {
            ocultar();
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
        lblMje.Text = "Ingrese  el cógido de la DVenta y presione el botón Buscar";
    }
    private void ocultar()
    {
        txtCodigo.Enabled = true;
        divOcultar.Visible = false;
        btnEliminar.Text = "Buscar";
        btnRetornar.Enabled = false;
        btnBorrar.Enabled = true;
    }

    private void visualizar()
    {
        txtCodigo.Enabled = false;
        divOcultar.Visible = true;
        btnEliminar.Text = "Eliminar";
        btnRetornar.Enabled = true;
        btnBorrar.Enabled = false;
    }

    private void cargarDVenta()
    {
        txtCodigo.Text = objDVenta.DVentaId;
        txtCantidad.Text = objDVenta.Cantidad.ToString();
        txtPrecio.Text = objDVenta.Precio.ToString();
        ddlVenta.ClearSelection();
        ddlVenta.Items.FindByValue(objDVenta.VentaId).Selected = true;
        ddlArticulo.ClearSelection();
        ddlArticulo.Items.FindByValue(objDVenta.ArticuloId).Selected = true;
    }

    private void mostraMjeBuscar(DVenta objDVenta)
    {
        lblMje.ForeColor = objDVenta.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        if (objDVenta.Estado == 99)
        {
            lblMje.Text = "Estos son los datos; visualize y si está seguro que desea eliminarlo pulse Eliminar.";
        }
        else
        {
            lblMje.Text = "DVenta [" + objDVenta.DVentaId + "] NO EXISTE.";
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
        txtCodigo.Text = "";
    }

    private void mostrarMjeEliminar(DVenta objDVenta)
    {
        lblMje.ForeColor = objDVenta.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objDVenta.Estado)
        {

            case 0: //error de código
                lblMje.Text = "Estado = 0.";
                break;
            case 1: //error de código
                lblMje.Text = "DVenta [" + objDVenta.DVentaId + "] NO EXISTE.";
                break;
            case 99: //Producto registrado
                lblMje.Text = "DVenta " + objDVenta.DVentaId + " eliminado satisfactoriamente.";
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
            objDVenta = new DVenta();
            objDVenta.DVentaId = txtCodigo.Text;
            objDVenta = objProxy.LeerDVenta(objDVenta);
            mostraMjeBuscar(objDVenta);
            if (objDVenta.Estado == 99)
            {
                cargarDVenta();
                visualizar();
            }
        }
        else
        {
            objDVenta = new DVenta();
            objDVenta.DVentaId = txtCodigo.Text;
            objDVenta = objProxy.EliminarDVenta(objDVenta);
            mostrarMjeEliminar(objDVenta);
            if (objDVenta.Estado == 99)
            {
                ocultar();
            }
        }
    }
}