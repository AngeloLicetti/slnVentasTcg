using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cpMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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