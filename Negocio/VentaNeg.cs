using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using tcgGestionDatos;
using tcgDominio;

namespace tcgNegocio
{
    public class VentaNeg
    {
        VentaDat objVentaDat;
        DVentaDat objDVentaDat;
        ClienteDat objClienteDat;
        TrabajadorDat objTrabajadorDat;
        public VentaNeg()
        {
            objVentaDat = new VentaDat();
            objDVentaDat = new DVentaDat();
            objClienteDat = new ClienteDat();
            objTrabajadorDat = new TrabajadorDat();
        }
        public void RegistrarVenta(Venta objVenta)
        {
            bool correcto = true;
            //Codigo de Venta:  digitos significativos: entre 10001 y 99999; error = 1
            int nCodigo;
            try
            {
                nCodigo = int.Parse(objVenta.VentaId);
                correcto = nCodigo >= 10000 && nCodigo < 100000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objVenta.Estado = 1;
                return;
            }
            //Fecha: ; error 2
            correcto = (DateTime.Compare(objVenta.Fecha.Date, DateTime.Now.Date.AddDays(-10)) > 0) && (DateTime.Compare(objVenta.Fecha.Date, DateTime.Now.Date) <= 0);
            if (!correcto)
            {
                objVenta.Estado = 2;
                return;
            }
            //Comentario: entre 1 caracter significativo y 100; error 3
            string sComentario = objVenta.Comentario.Trim();
            correcto = sComentario.Length > 0 && sComentario.Length < 101;
            if (!correcto)
            {
                objVenta.Estado = 3;
                return;
            }
            
            //Verificar que Cliente exista; error 4
            Cliente objClienteT = new Cliente();
            objClienteT.ClienteId = objVenta.ClienteId;
            correcto = objClienteDat.SelectCliente(objClienteT);
            if (!correcto)
            {
                objVenta.Estado = 4;
                return;
            }
            //Verificar que Trabajador exista; error 5
            Trabajador objTrabajadorT = new Trabajador();
            objTrabajadorT.TrabajadorId = objVenta.TrabajadorId;
            correcto = objTrabajadorDat.SelectTrabajador(objTrabajadorT);
            if (!correcto)
            {
                objVenta.Estado = 5;
                return;
            }
            //Verificar duplicidad: error = 22
            Venta objVentaT = new Venta();
            objVentaT.VentaId = objVenta.VentaId;
            correcto = !objVentaDat.SelectVenta(objVentaT);
            if (!correcto)
            {
                objVenta.Estado = 22;
                return;
            }
            //registro de la Venta en la tabla
            objVentaDat.InsertVenta(objVenta);
            objVenta.Estado = 99;
        }
        public void ActualizarVenta(Venta objVenta)
        {
            bool correcto = true;
            //Verificar que Venta exista, error = 1
            Venta objVentaT = new Venta();
            objVentaT.VentaId = objVenta.VentaId;
            correcto = objVentaDat.SelectVenta(objVentaT);

            if (!correcto)
            {
                objVenta.Estado = 1;
                return;
            }
            //SE PUEDE CREAR UN METODO PARA HACER LO QUE SIGUE Y NO REPETIRLO!
            //Fecha: ; error 2
            correcto = (DateTime.Compare(objVenta.Fecha.Date, DateTime.Now.Date.AddDays(-10)) > 0) && (DateTime.Compare(objVenta.Fecha.Date, DateTime.Now.Date) <= 0);
            if (!correcto)
            {
                objVenta.Estado = 2;
                return;
            }
            //Comentario: entre 1 caracter significativo y 100; error 3
            string sComentario = objVenta.Comentario.Trim();
            correcto = sComentario.Length > 0 && sComentario.Length < 101;
            if (!correcto)
            {
                objVenta.Estado = 3;
                return;
            }
            //Verificar que Cliente exista; error 4
            Cliente objClienteT = new Cliente();
            objClienteT.ClienteId = objVenta.ClienteId;
            correcto = objClienteDat.SelectCliente(objClienteT);
            if (!correcto)
            {
                objVenta.Estado = 4;
                return;
            }
            //Verificar que Trabajador exista; error 5
            Trabajador objTrabajadorT = new Trabajador();
            objTrabajadorT.TrabajadorId = objVenta.TrabajadorId;
            correcto = objTrabajadorDat.SelectTrabajador(objTrabajadorT);
            if (!correcto)
            {
                objVenta.Estado = 5;
                return;
            }
            //registro de actualizacion de Venta en tabla
            objVentaDat.UpdateVenta(objVenta);
            objVenta.Estado = 99;
        }
        public void EliminarVenta(Venta objVenta)
        {
            bool correcto = true;
            //Verificar que Venta exista, error = 1
            Venta objVentaT = new Venta();
            objVentaT.VentaId = objVenta.VentaId;
            correcto = objVentaDat.SelectVenta(objVentaT);

            if (!correcto)
            {
                objVenta.Estado = 1;
                return;
            }
            //VERIFICAR QUE NO TENGA HIJOS EN DVenta!
            DVenta objDVentaT = new DVenta();
            objDVentaT.VentaId = objVenta.VentaId;
            correcto = !objDVentaDat.SelectDVentaPorVentaId(objDVentaT);

            if (!correcto)
            {
                objVenta.Estado = 2;
                return;
            }
            //eliminacion de Venta en tabla
            objVentaDat.DeleteVenta(objVenta);
            objVenta.Estado = 99;
        }

        public bool LeerVenta(Venta objVenta)
        {
            return objVentaDat.SelectVenta(objVenta);
        }

        public DataSet LeerVentas()
        {
            return objVentaDat.SelectVentas();
        }
    }
}
