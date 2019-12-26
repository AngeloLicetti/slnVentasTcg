using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tcgGestionDatos;
using tcgNegocio;
using System.Data;

public partial class cpFacturaLis : System.Web.UI.Page
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

    protected void btnSalir_Click(object sender, EventArgs e)
    {
        string close = @"<script type='text/javascript' >
                            window.open('','_parent','');
                            window.close();
                        </script>";
        Response.Write(close);
    }
}