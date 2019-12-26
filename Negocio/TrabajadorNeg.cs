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
    public class TrabajadorNeg
    {
        TrabajadorDat objTrabajadorDat;
        VentaDat objVentaDat;
        public TrabajadorNeg()
        {
            objTrabajadorDat = new TrabajadorDat();
            objVentaDat = new VentaDat();
        }
        public void RegistrarTrabajador(Trabajador objTrabajador)
        {
            bool correcto = true;
            //codigo de Trabajador: digitos significativos: entre 10001 y 99999; error = 1
            int nCodigo;
            try
            {
                nCodigo = int.Parse(objTrabajador.TrabajadorId);
                correcto = nCodigo >= 10000 && nCodigo < 100000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objTrabajador.Estado = 1;
                return;
            }
            //Apellidos: entre 2 caracter significativo y 30; error = 2
            string sApellidos = objTrabajador.Apellidos.Trim();
            correcto = sApellidos.Length > 1 && sApellidos.Length < 31;
            if (!correcto)
            {
                objTrabajador.Estado = 2;
                return;
            }
            objTrabajador.Apellidos = sApellidos;
            //Nombres: entre 2 caracter significativo y 30; error 3
            string sNombres = objTrabajador.Nombres.Trim();
            correcto = sNombres.Length > 1 && sNombres.Length < 31;
            if (!correcto)
            {
                objTrabajador.Estado = 3;
                return;
            }
            objTrabajador.Nombres = sNombres;
            //Cargo: entre 2 caracter significativo y 30; error = 4
            string sCargo = objTrabajador.Cargo.Trim();
            correcto = sCargo.Length > 1 && sCargo.Length < 31;
            if (!correcto)
            {
                objTrabajador.Estado = 4;
                return;
            }
            objTrabajador.Cargo = sCargo;
            //Dni: 8 cifras significativas; error 5
            int nDni;
            try
            {
                nDni = int.Parse(objTrabajador.Dni);
                correcto = nDni > 10000000 && nDni < 100000000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objTrabajador.Estado = 5;
                return;
            }
            //Celular: 9 cifras significativas; error = 6
            int nCelular;
            try
            {
                nCelular = int.Parse(objTrabajador.Celular);
                correcto = nCelular > 100000000 && nCelular < 1000000000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objTrabajador.Estado = 6;
                return;
            }
            //Direccion: entre 2 caracter significativo y 50; error 7
            string sDireccion = objTrabajador.Direccion.Trim();
            correcto = sDireccion.Length > 1 && sDireccion.Length < 51;
            if (!correcto)
            {
                objTrabajador.Estado = 7;
                return;
            }
            objTrabajador.Direccion = sDireccion;
            //Email: entre 2 caracter significativo y 40; error 8
            string sEmail = objTrabajador.Email.Trim();
            correcto = sEmail.Length > 1 && sEmail.Length < 41;
            correcto = ComprobarFormatoEmail(sEmail);
            if (!correcto)
            {
                objTrabajador.Estado = 8;
                return;
            }
            objTrabajador.Email = sEmail;
            //Imagen: ; error 9
            
            if (!correcto)
            {
                objTrabajador.Estado = 9;
                return;
            }
            //Verificar duplicidad: error = 22
            Trabajador objTrabajadorT = new Trabajador();
            objTrabajadorT.TrabajadorId = objTrabajador.TrabajadorId;
            correcto = !objTrabajadorDat.SelectTrabajador(objTrabajadorT);
            if (!correcto)
            {
                objTrabajador.Estado = 22;
                return;
            }
            //registro de la Trabajador en la tabla
            objTrabajadorDat.InsertTrabajador(objTrabajador);
            objTrabajador.Estado = 99;
        }
        public void ActualizarTrabajador(Trabajador objTrabajador)
        {
            bool correcto = true;
            //Verificar que Trabajador exista, error = 1
            Trabajador objTrabajadorT = new Trabajador();
            objTrabajadorT.TrabajadorId = objTrabajador.TrabajadorId;
            correcto = objTrabajadorDat.SelectTrabajador(objTrabajadorT);

            if (!correcto)
            {
                objTrabajador.Estado = 1;
                return;
            }
            //SE PUEDE CREAR UN METODO PARA HACER LO QUE SIGUE Y NO REPETIRLO!
            //Apellidos: entre 2 caracter significativo y 30; error = 2
            string sApellidos = objTrabajador.Apellidos.Trim();
            correcto = sApellidos.Length > 1 && sApellidos.Length < 31;
            if (!correcto)
            {
                objTrabajador.Estado = 2;
                return;
            }
            objTrabajador.Apellidos = sApellidos;
            //Nombres: entre 2 caracter significativo y 30; error 3
            string sNombres = objTrabajador.Nombres.Trim();
            correcto = sNombres.Length > 1 && sNombres.Length < 31;
            if (!correcto)
            {
                objTrabajador.Estado = 3;
                return;
            }
            objTrabajador.Nombres = sNombres;
            //Cargo: entre 2 caracter significativo y 30; error = 4
            string sCargo = objTrabajador.Cargo.Trim();
            correcto = sCargo.Length > 1 && sCargo.Length < 31;
            if (!correcto)
            {
                objTrabajador.Estado = 4;
                return;
            }
            objTrabajador.Cargo = sCargo;
            //Dni: 8 cifras significativas; error 5
            int nDni;
            try
            {
                nDni = int.Parse(objTrabajador.Dni);
                correcto = nDni > 10000000 && nDni < 100000000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objTrabajador.Estado = 5;
                return;
            }
            //Celular: 9 cifras significativas; error = 6
            int nCelular;
            try
            {
                nCelular = int.Parse(objTrabajador.Celular);
                correcto = nCelular > 100000000 && nCelular < 1000000000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objTrabajador.Estado = 6;
                return;
            }
            //Direccion: entre 2 caracter significativo y 50; error 7
            string sDireccion = objTrabajador.Direccion.Trim();
            correcto = sDireccion.Length > 1 && sDireccion.Length < 51;
            if (!correcto)
            {
                objTrabajador.Estado = 7;
                return;
            }
            objTrabajador.Direccion = sDireccion;
            //Email: entre 2 caracter significativo y 40; error 8
            string sEmail = objTrabajador.Email.Trim();
            correcto = sEmail.Length > 1 && sEmail.Length < 41;
            correcto = ComprobarFormatoEmail(sEmail);
            if (!correcto)
            {
                objTrabajador.Estado = 8;
                return;
            }
            objTrabajador.Email = sEmail;
            //Imagen: ; error 9

            if (!correcto)
            {
                objTrabajador.Estado = 9;
                return;
            }
            //registro de actualizacion de Trabajador en tabla
            objTrabajadorDat.UpdateTrabajador(objTrabajador);
            objTrabajador.Estado = 99;
        }
        public void EliminarTrabajador(Trabajador objTrabajador)
        {
            bool correcto = true;
            //Verificar que Trabajador exista, error = 1
            Trabajador objTrabajadorT = new Trabajador();
            objTrabajadorT.TrabajadorId = objTrabajador.TrabajadorId;
            correcto = objTrabajadorDat.SelectTrabajador(objTrabajadorT);

            if (!correcto)
            {
                objTrabajador.Estado = 1;
                return;
            }

            //VERIFICAR QUE NO TENGA HIJOS EN Venta!
            Venta objVentaT = new Venta();
            objVentaT.TrabajadorId = objTrabajador.TrabajadorId;
            correcto = !objVentaDat.SelectVentaPorTrabajadorId(objVentaT);

            if (!correcto)
            {
                objTrabajador.Estado = 2;
                return;
            }

            //eliminacion de Trabajador en tabla
            objTrabajadorDat.DeleteTrabajador(objTrabajador);
            objTrabajador.Estado = 99;
        }

        public bool LeerTrabajador(Trabajador objTrabajador)
        {
            return objTrabajadorDat.SelectTrabajador(objTrabajador);
        }

        public DataSet LeerTrabajadors()
        {
            return objTrabajadorDat.SelectTrabajadors();
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
