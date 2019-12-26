using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using tcgDominio;
using tcgNegocio;
using System.Data;

/// <summary>
/// Summary description for wsCliente
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsCliente : System.Web.Services.WebService
{
    private ClienteNeg objClienteNeg;

    public wsCliente()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        objClienteNeg = new ClienteNeg();
    }


    [WebMethod]
    public Cliente RegistrarCliente(Cliente objCliente)
    {
        objClienteNeg.RegistrarCliente(objCliente);
        return objCliente;
    }

    [WebMethod]
    public Cliente ActualizarCliente(Cliente objCliente)
    {
        objClienteNeg.ActualizarCliente(objCliente);
        return objCliente;
    }

    [WebMethod]
    public Cliente EliminarCliente(Cliente objCliente)
    {
        objClienteNeg.EliminarCliente(objCliente);
        return objCliente;
    }

    [WebMethod]
    public Cliente LeerCliente(Cliente objCliente)
    {
        objClienteNeg.LeerCliente(objCliente);
        return objCliente;
    }

    [WebMethod]
    public DataSet LeerClientes()
    {
        return objClienteNeg.LeerClientes();
    }

}
