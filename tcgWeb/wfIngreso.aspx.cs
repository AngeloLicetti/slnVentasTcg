using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


public partial class wfIngreso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        mjeInicial();
       
    }

    protected void btnsalir_Click(object sender, EventArgs e)
    {
   
    }

    protected void btnngresar_Click(object sender, EventArgs e)
    {
        if (txtusuario.Text == "admin" && txtclave.Text == "123")
        {
           
            txtusuario.Text="";
            txtclave.Text="";

            lblmensaje.Text = "Usuario y clave correctos.";

            

        }
        else
        {
            lblmensaje.ForeColor = Color.Red;
            lblmensaje.Text = "Usuario o clave incorrectos.";
        }
    }
    private void mjeInicial()
    {
        lblmensaje.ForeColor = Color.Blue;
        lblmensaje.Text = "Para ingresar escriba su usuario y clave y para salir pulse salir.";
    }



    protected void btnsal_Click(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
}