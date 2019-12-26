using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using tcgDominio;
using tcgNegocio;
using System.Data;

/// <summary>
/// Summary description for wsDVenta
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsDVenta : System.Web.Services.WebService
{

    private DVentaNeg objDVentaNeg;

    public wsDVenta()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        objDVentaNeg = new DVentaNeg();
    }


    [WebMethod]
    public DVenta RegistrarDVenta(DVenta objDVenta)
    {
        objDVentaNeg.RegistrarDVenta(objDVenta);
        return objDVenta;
    }

    [WebMethod]
    public DVenta ActualizarDVenta(DVenta objDVenta)
    {
        objDVentaNeg.ActualizarDVenta(objDVenta);
        return objDVenta;
    }

    [WebMethod]
    public DVenta EliminarDVenta(DVenta objDVenta)
    {
        objDVentaNeg.EliminarDVenta(objDVenta);
        return objDVenta;
    }

    [WebMethod]
    public DVenta LeerDVenta(DVenta objDVenta)
    {
        objDVentaNeg.LeerDVenta(objDVenta);
        return objDVenta;
    }

    [WebMethod]
    public DataSet LeerDVentas()
    {
        return objDVentaNeg.LeerDVentas();
    }

}
