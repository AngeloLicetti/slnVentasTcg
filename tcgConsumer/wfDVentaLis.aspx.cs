using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;
using System.Data;

public partial class wfDVentaLis : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            wsDVenta proxyDVenta = new wsDVenta();
            DataSet ds = proxyDVenta.LeerDVentas();
            gvLista.DataSource = ds.Tables[0];
            gvLista.DataBind();
        }
    }
}