using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using tcgDominio;
using tcgNegocio;
using System.Data;

/// <summary>
/// Summary description for wsVenta
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsVenta : System.Web.Services.WebService
{

    private VentaNeg objVentaNeg;

    public wsVenta()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        objVentaNeg = new VentaNeg();
    }


    [WebMethod]
    public Venta RegistrarVenta(Venta objVenta)
    {
        objVentaNeg.RegistrarVenta(objVenta);
        return objVenta;
    }

    [WebMethod]
    public Venta ActualizarVenta(Venta objVenta)
    {
        objVentaNeg.ActualizarVenta(objVenta);
        return objVenta;
    }

    [WebMethod]
    public Venta EliminarVenta(Venta objVenta)
    {
        objVentaNeg.EliminarVenta(objVenta);
        return objVenta;
    }

    [WebMethod]
    public Venta LeerVenta(Venta objVenta)
    {
        objVentaNeg.LeerVenta(objVenta);
        return objVenta;
    }

    [WebMethod]
    public DataSet LeerVentas()
    {
        return objVentaNeg.LeerVentas();
    }

}
