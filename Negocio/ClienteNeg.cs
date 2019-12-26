using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using tcgGestionDatos;
using tcgDominio;

namespace tcgNegocio
{
    public class ClienteNeg
    {
        ClienteDat objClienteDat;
        VentaDat objVentaDat;
        public ClienteNeg()
        {
            objClienteDat = new ClienteDat();
            objVentaDat = new VentaDat();
        }
        public void RegistrarCliente(Cliente objCliente)
        {
            bool correcto = true;
            //codigo de Cliente: digitos significativos: entre 10001 y 99999; error = 1
            int nCodigo;
            try
            {
                nCodigo = int.Parse(objCliente.ClienteId);
                correcto = nCodigo >= 10000 && nCodigo < 100000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objCliente.Estado = 1;
                return;
            }
            //Apellidos: entre 2 caracter significativo y 30; error = 2
            string sApellidos = objCliente.Apellidos.Trim();
            correcto = sApellidos.Length > 1 && sApellidos.Length < 31;
            if (!correcto)
            {
                objCliente.Estado = 2;
                return;
            }
            objCliente.Apellidos = sApellidos;
            //Nombres: entre 2 caracter significativo y 30; error 3
            string sNombres = objCliente.Nombres.Trim();
            correcto = sNombres.Length > 1 && sNombres.Length < 31;
            if (!correcto)
            {
                objCliente.Estado = 3;
                return;
            }
            objCliente.Nombres = sNombres;
            //Celular: 9 cifras significativas; error = 4
            int nCelular;
            try
            {
                nCelular = int.Parse(objCliente.Celular);
                correcto = nCelular > 100000000 && nCelular < 1000000000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objCliente.Estado = 4;
                return;
            }
            //Direccion: entre 2 caracter significativo y 50; error 5
            string sDireccion = objCliente.Direccion.Trim();
            correcto = sDireccion.Length > 1 && sDireccion.Length < 51;
            if (!correcto)
            {
                objCliente.Estado = 5;
                return;
            }
            objCliente.Direccion = sDireccion;
            //Email: entre 2 caracter significativo y 40; error 6
            string sEmail = objCliente.Email.Trim();
            correcto = sEmail.Length > 1 && sEmail.Length < 41 && ComprobarFormatoEmail(sEmail);
            if (!correcto)
            {
                objCliente.Estado = 6;
                return;
            }
            objCliente.Email = sEmail;
            //Imagen: ; error 7

            if (!correcto)
            {
                objCliente.Estado = 7;
                return;
            }
            //Verificar duplicidad: error = 22
            Cliente objClienteT = new Cliente();
            objClienteT.ClienteId = objCliente.ClienteId;
            correcto = !objClienteDat.SelectCliente(objClienteT);
            if (!correcto)
            {
                objCliente.Estado = 22;
                return;
            }
            //registro de la Cliente en la tabla
            objClienteDat.InsertCliente(objCliente);
            objCliente.Estado = 99;
        }
        public void ActualizarCliente(Cliente objCliente)
        {
            bool correcto = true;
            //Verificar que Cliente exista, error = 1
            Cliente objClienteT = new Cliente();
            objClienteT.ClienteId = objCliente.ClienteId;
            correcto = objClienteDat.SelectCliente(objClienteT);

            if (!correcto)
            {
                objCliente.Estado = 1;
                return;
            }
            //SE PUEDE CREAR UN METODO PARA HACER LO QUE SIGUE Y NO REPETIRLO!
            //Apellidos: entre 2 caracter significativo y 30; error = 2
            string sApellidos = objCliente.Apellidos.Trim();
            correcto = sApellidos.Length > 1 && sApellidos.Length < 31;
            if (!correcto)
            {
                objCliente.Estado = 2;
                return;
            }
            objCliente.Apellidos = sApellidos;
            //Nombres: entre 2 caracter significativo y 30; error 3
            string sNombres = objCliente.Nombres.Trim();
            correcto = sNombres.Length > 1 && sNombres.Length < 31;
            if (!correcto)
            {
                objCliente.Estado = 3;
                return;
            }
            objCliente.Nombres = sNombres;
            //Celular: 9 cifras significativas; error = 4
            int nCelular;
            try
            {
                nCelular = int.Parse(objCliente.Celular);
                correcto = nCelular > 100000000 && nCelular < 1000000000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objCliente.Estado = 4;
                return;
            }
            //Direccion: entre 2 caracter significativo y 50; error 5
            string sDireccion = objCliente.Direccion.Trim();
            correcto = sDireccion.Length > 1 && sDireccion.Length < 51;
            if (!correcto)
            {
                objCliente.Estado = 5;
                return;
            }
            objCliente.Direccion = sDireccion;
            //Email: entre 2 caracter significativo y 40; error 6
            string sEmail = objCliente.Email.Trim();
            correcto = sEmail.Length > 1 && sEmail.Length < 41 && ComprobarFormatoEmail(sEmail);
            if (!correcto)
            {
                objCliente.Estado = 6;
                return;
            }
            objCliente.Email = sEmail;
            //Imagen: ; error 7

            if (!correcto)
            {
                objCliente.Estado = 7;
                return;
            }
            //registro de actualizacion de Cliente en tabla
            objClienteDat.UpdateCliente(objCliente);
            objCliente.Estado = 99;
        }
        public void EliminarCliente(Cliente objCliente)
        {
            bool correcto = true;
            //Verificar que Cliente exista, error = 1
            Cliente objClienteT = new Cliente();
            objClienteT.ClienteId = objCliente.ClienteId;
            correcto = objClienteDat.SelectCliente(objClienteT);

            if (!correcto)
            {
                objCliente.Estado = 1;
                return;
            }

            //VERIFICAR QUE NO TENGA HIJOS EN Venta!
            Venta objVentaT = new Venta();
            objVentaT.ClienteId = objCliente.ClienteId;
            correcto = !objVentaDat.SelectVentaPorClienteId(objVentaT);

            if (!correcto)
            {
                objCliente.Estado = 2;
                return;
            }

            //eliminacion de Cliente en tabla
            objClienteDat.DeleteCliente(objCliente);
            objCliente.Estado = 99;
        }

        public bool LeerCliente(Cliente objCliente)
        {
            return objClienteDat.SelectCliente(objCliente);
        }

        public DataSet LeerClientes()
        {
            return objClienteDat.SelectClientes();
        }
        public bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
