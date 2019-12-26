using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tcgDominio;
using tcgGestionDatos;
using tcgNegocio;
using System.Data;

public partial class wfFacturaLis : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            VentaNeg objVentaNeg = new VentaNeg();
            DataSet ds = objVentaNeg.LeerVentas();
            gvLista.DataSource = ds.Tables[0];
            gvLista.DataBind();
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("WfMenu.aspx");
    }
}