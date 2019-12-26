using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.Mobile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using localhost;

public partial class wmTrabajadorLis : System.Web.UI.MobileControls.MobilePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            wsTrabajador proxyTrabajador = new wsTrabajador();
            DataSet ds = proxyTrabajador.LeerTrabajadors();
            gvLista.DataSource = ds.Tables[0];
            gvLista.DataBind();
        }
    }

    public void btnRetornar_Click(object sender, EventArgs e)
    {
        this.RedirectToMobilePage("Default.aspx");
    }
}