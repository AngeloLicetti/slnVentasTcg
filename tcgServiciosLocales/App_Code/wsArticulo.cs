using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using tcgDominio;
using tcgNegocio;
using System.Data;

/// <summary>
/// Summary description for wsArticulo
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsArticulo : System.Web.Services.WebService
{

    private ArticuloNeg objArticuloNeg;

    public wsArticulo()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        objArticuloNeg = new ArticuloNeg();
    }


    [WebMethod]
    public Articulo RegistrarArticulo(Articulo objArticulo)
    {
        objArticuloNeg.RegistrarArticulo(objArticulo);
        return objArticulo;
    }

    [WebMethod]
    public Articulo ActualizarArticulo(Articulo objArticulo)
    {
        objArticuloNeg.ActualizarArticulo(objArticulo);
        return objArticulo;
    }

    [WebMethod]
    public Articulo EliminarArticulo(Articulo objArticulo)
    {
        objArticuloNeg.EliminarArticulo(objArticulo);
        return objArticulo;
    }

    [WebMethod]
    public Articulo LeerArticulo(Articulo objArticulo)
    {
        objArticuloNeg.LeerArticulo(objArticulo);
        return objArticulo;
    }

    [WebMethod]
    public DataSet LeerArticulos()
    {
        return objArticuloNeg.LeerArticulos();
    }

}
