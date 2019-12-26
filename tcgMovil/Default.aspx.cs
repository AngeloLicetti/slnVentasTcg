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


public partial class _Default : System.Web.UI.MobileControls.MobilePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lstIdiomas_ItemCommand(object sender, ListCommandEventArgs e)
    {
        switch (e.ListItem.Text)
        {
            case "Registrar trabajador":
                this.RedirectToMobilePage("wmTrabajadorAdi.aspx");
                break;

            case "Actualizar trabajador":
                this.RedirectToMobilePage("wmTrabajadorAct.aspx");
                break;
            case "Eliminar trabajador":
                this.RedirectToMobilePage("wmTrabajadorEli.aspx");
                break;
            case "Consultar trabajador":
                this.RedirectToMobilePage("wmTrabajadorCon.aspx");
                break;
            case "Listar trabajador":
                this.RedirectToMobilePage("wmTrabajadorLis.aspx");
                break;
            case "Salir":
                string close = @"<script type='text/javascript' >
                            window.open('','_parent','');
                            window.close();
                        </script>";
                Response.Write(close);
                break;
            default:
                this.RedirectToMobilePage("Default.aspx");
                break;
        }

    }

}