using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using tcgDominio;
using tcgNegocio;
using System.Data;

/// <summary>
/// Summary description for wsTrabajador
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsTrabajador : System.Web.Services.WebService
{

    private TrabajadorNeg objTrabajadorNeg;

    public wsTrabajador()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        objTrabajadorNeg = new TrabajadorNeg();
    }


    [WebMethod]
    public Trabajador RegistrarTrabajador(Trabajador objTrabajador)
    {
        objTrabajadorNeg.RegistrarTrabajador(objTrabajador);
        return objTrabajador;
    }

    [WebMethod]
    public Trabajador ActualizarTrabajador(Trabajador objTrabajador)
    {
        objTrabajadorNeg.ActualizarTrabajador(objTrabajador);
        return objTrabajador;
    }

    [WebMethod]
    public Trabajador EliminarTrabajador(Trabajador objTrabajador)
    {
        objTrabajadorNeg.EliminarTrabajador(objTrabajador);
        return objTrabajador;
    }

    [WebMethod]
    public Trabajador LeerTrabajador(Trabajador objTrabajador)
    {
        objTrabajadorNeg.LeerTrabajador(objTrabajador);
        return objTrabajador;
    }

    [WebMethod]
    public DataSet LeerTrabajadors()
    {
        return objTrabajadorNeg.LeerTrabajadors();
    }

}
