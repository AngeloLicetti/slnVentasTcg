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
    public class DVentaNeg
    {
        DVentaDat objDVentaDat;
        VentaDat objVentaDat;
        ArticuloDat objArticuloDat;
        public DVentaNeg()
        {
            objDVentaDat = new DVentaDat();
            objVentaDat = new VentaDat();
            objArticuloDat = new ArticuloDat();
        }
        public void RegistrarDVenta(DVenta objDVenta)
        {
            bool correcto = true;
            //Codigo de DVenta:  digitos significativos: entre 10001 y 99999; error = 1
            int nCodigo;
            try
            {
                nCodigo = int.Parse(objDVenta.DVentaId);
                correcto = nCodigo >= 10000 && nCodigo < 100000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objDVenta.Estado = 1;
                return;
            }
            //Cantidad: mayor o igual que 0; error 2
            correcto = objDVenta.Cantidad >= 0;
            if (!correcto)
            {
                objDVenta.Estado = 2;
                return;
            }
            //Precio: mayor o igual que 0; error 3
            double fPrecio = objDVenta.Precio;
            correcto = fPrecio >= 0;
            if (!correcto)
            {
                objDVenta.Estado = 3;
                return;
            }
            objDVenta.Precio = (double)(Math.Truncate((double)fPrecio * 100.0) / 100.0);
            //Verificar que Venta exista; error 4
            Venta objVentaT = new Venta();
            objVentaT.VentaId = objDVenta.VentaId;
            correcto = objVentaDat.SelectVenta(objVentaT);
            if (!correcto)
            {
                objDVenta.Estado = 4;
                return;
            }
            //Verificar que Articulo exista; error 5
            Articulo objArticuloT = new Articulo();
            objArticuloT.ArticuloId = objDVenta.ArticuloId;
            correcto = objArticuloDat.SelectArticulo(objArticuloT);
            if (!correcto)
            {
                objDVenta.Estado = 5;
                return;
            }
            //Verificar duplicidad: error = 22
            DVenta objDVentaT = new DVenta();
            objDVentaT.DVentaId = objDVenta.DVentaId;
            correcto = !objDVentaDat.SelectDVenta(objDVentaT);
            if (!correcto)
            {
                objDVenta.Estado = 22;
                return;
            }
            //registro de la DVenta en la tabla
            objDVentaDat.InsertDVenta(objDVenta);
            objDVenta.Estado = 99;
        }
        public void ActualizarDVenta(DVenta objDVenta)
        {
            bool correcto = true;
            //Verificar que DVenta exista, error = 1
            DVenta objDVentaT = new DVenta();
            objDVentaT.DVentaId = objDVenta.DVentaId;
            correcto = objDVentaDat.SelectDVenta(objDVentaT);

            if (!correcto)
            {
                objDVenta.Estado = 1;
                return;
            }
            //SE PUEDE CREAR UN METODO PARA HACER LO QUE SIGUE Y NO REPETIRLO!
            //Cantidad: mayor o igual que 0; error 2
            correcto = objDVenta.Cantidad >= 0;
            if (!correcto)
            {
                objDVenta.Estado = 2;
                return;
            }
            //Precio: mayor o igual que 0; error 3
            double fPrecio = objDVenta.Precio;
            correcto = fPrecio >= 0;
            if (!correcto)
            {
                objDVenta.Estado = 3;
                return;
            }
            objDVenta.Precio = (double)(Math.Truncate((double)fPrecio * 100.0) / 100.0);
            //Verificar que Venta exista; error 4
            Venta objVentaT = new Venta();
            objVentaT.VentaId = objDVenta.VentaId;
            correcto = objVentaDat.SelectVenta(objVentaT);
            if (!correcto)
            {
                objDVenta.Estado = 4;
                return;
            }
            //Verificar que Articulo exista; error 5
            Articulo objArticuloT = new Articulo();
            objArticuloT.ArticuloId = objDVenta.ArticuloId;
            correcto = objArticuloDat.SelectArticulo(objArticuloT);
            if (!correcto)
            {
                objDVenta.Estado = 5;
                return;
            }
            //registro de actualizacion de DVenta en tabla
            objDVentaDat.UpdateDVenta(objDVenta);
            objDVenta.Estado = 99;
        }
        public void EliminarDVenta(DVenta objDVenta)
        {
            bool correcto = true;
            //Verificar que DVenta exista, error = 1
            DVenta objDVentaT = new DVenta();
            objDVentaT.DVentaId = objDVenta.DVentaId;
            correcto = objDVentaDat.SelectDVenta(objDVentaT);

            if (!correcto)
            {
                objDVenta.Estado = 1;
                return;
            }
            
            //eliminacion de DVenta en tabla
            objDVentaDat.DeleteDVenta(objDVenta);
            objDVenta.Estado = 99;
        }

        public bool LeerDVenta(DVenta objDVenta)
        {
            return objDVentaDat.SelectDVenta(objDVenta);
        }

        public DataSet LeerDVentas()
        {
            return objDVentaDat.SelectDVentas();
        }
    }
}
