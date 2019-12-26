using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WfMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnListarFacturas_Click(object sender, EventArgs e)
    {
        Response.Redirect("wfFacturaLis.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("wfFacturaAdi.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("wfFacturaAct.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("wfFacturaEli.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("wfFacturaCon.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        string close = @"<script type='text/javascript' >
                            window.open('','_parent','');
                            window.close();
                        </script>";
        Response.Write(close);
    }

}