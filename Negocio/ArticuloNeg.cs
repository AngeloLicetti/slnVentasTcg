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
    public class ArticuloNeg
    {
        ArticuloDat objArticuloDat;
        DVentaDat objDVentaDat;
        UMedidaDat objUMedidaDat;
        public ArticuloNeg()
        {
            objArticuloDat = new ArticuloDat();
            objDVentaDat = new DVentaDat();
            objUMedidaDat = new UMedidaDat();
        }
        public void RegistrarArticulo(Articulo objArticulo)
        {
            bool correcto = true;
            //Codigo de Articulo:  digitos significativos: entre 10001 y 99999; error = 1
            int nCodigo;
            try
            {
                nCodigo = int.Parse(objArticulo.ArticuloId);
                correcto = nCodigo >= 10000 && nCodigo < 100000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objArticulo.Estado = 1;
                return;
            }

            //Nombre: entre 5 caracter significativo y 30; error = 2
            string sNombre = objArticulo.Nombre.Trim();
            correcto = sNombre.Length > 4 && sNombre.Length < 31;
            if (!correcto)
            {
                objArticulo.Estado = 2;
                return;
            }
            objArticulo.Nombre = sNombre;
            //Descripcion: entre 1 caracter significativo y 50; error 3
            string sDescripcion = objArticulo.Descripcion.Trim();
            correcto = sDescripcion.Length > 0 && sDescripcion.Length < 51;
            if (!correcto)
            {
                objArticulo.Estado = 3;
                return;
            }
            objArticulo.Descripcion = sDescripcion;
            //Cantidad: mayor o igual que 0; error 4
            correcto = objArticulo.Cantidad >= 0;
            if (!correcto)
            {
                objArticulo.Estado = 4;
                return;
            }
            //Precio: mayor o igual que 0; error 5
            double fPrecio = objArticulo.Precio;
            correcto = fPrecio >= 0;
            if (!correcto)
            {
                objArticulo.Estado = 5;
                return;
            }
            objArticulo.Precio= (double)(Math.Truncate((double)fPrecio * 100.0) / 100.0);
            //Imagen; error 6

            //Verificar que UMedida exista; error 7
            UMedida objUMedidaT = new UMedida();
            objUMedidaT.UMedidaId = objArticulo.UMedidaId;
            correcto = objUMedidaDat.SelectUMedida(objUMedidaT);
            if (!correcto)
            {
                objArticulo.Estado = 7;
                return;
            }
            //Verificar duplicidad: error = 22
            Articulo objArticuloT = new Articulo();
            objArticuloT.ArticuloId = objArticulo.ArticuloId;
            correcto = !objArticuloDat.SelectArticulo(objArticuloT);
            if (!correcto)
            {
                objArticulo.Estado = 22;
                return;
            }
            //registro de la Articulo en la tabla
            objArticuloDat.InsertArticulo(objArticulo);
            objArticulo.Estado = 99;
        }
        public void ActualizarArticulo(Articulo objArticulo)
        {
            bool correcto = true;
            //Verificar que Articulo exista, error = 1
            Articulo objArticuloT = new Articulo();
            objArticuloT.ArticuloId = objArticulo.ArticuloId;
            correcto = objArticuloDat.SelectArticulo(objArticuloT);

            if (!correcto)
            {
                objArticulo.Estado = 1;
                return;
            }
            //SE PUEDE CREAR UN METODO PARA HACER LO QUE SIGUE Y NO REPETIRLO!
            //Nombre: entre 5 caracter significativo y 30; error = 2
            string sNombre = objArticulo.Nombre.Trim();
            correcto = sNombre.Length > 4 && sNombre.Length < 31;
            if (!correcto)
            {
                objArticulo.Estado = 2;
                return;
            }
            objArticulo.Nombre = sNombre;
            //Descripcion: entre 1 caracter significativo y 50; error 3
            string sDescripcion = objArticulo.Descripcion.Trim();
            correcto = sDescripcion.Length > 0 && sDescripcion.Length < 51;
            if (!correcto)
            {
                objArticulo.Estado = 3;
                return;
            }
            objArticulo.Descripcion = sDescripcion;
            //Cantidad: mayor o igual que 0; error 4
            correcto = objArticulo.Cantidad >= 0;
            if (!correcto)
            {
                objArticulo.Estado = 4;
                return;
            }
            //Precio: mayor o igual que 0; error 5
            double fPrecio = objArticulo.Precio;
            correcto = fPrecio >= 0;
            if (!correcto)
            {
                objArticulo.Estado = 5;
                return;
            }
            objArticulo.Precio = (double)(Math.Truncate((double)fPrecio * 100.0) / 100.0);
            //Imagen; error 6

            //Verificar que UMedida exista; error 7
            UMedida objUMedidaT = new UMedida();
            objUMedidaT.UMedidaId = objArticulo.UMedidaId;
            correcto = objUMedidaDat.SelectUMedida(objUMedidaT);
            if (!correcto)
            {
                objArticulo.Estado = 7;
                return;
            }
            //registro de actualizacion de Articulo en tabla
            objArticuloDat.UpdateArticulo(objArticulo);
            objArticulo.Estado = 99;
        }
        public void EliminarArticulo(Articulo objArticulo)
        {
            bool correcto = true;
            //Verificar que Articulo exista, error = 1
            Articulo objArticuloT = new Articulo();
            objArticuloT.ArticuloId = objArticulo.ArticuloId;
            correcto = objArticuloDat.SelectArticulo(objArticuloT);

            if (!correcto)
            {
                objArticulo.Estado = 1;
                return;
            }

            //VERIFICAR QUE NO TENGA HIJOS EN DVenta!
            DVenta objDVentaT = new DVenta();
            objDVentaT.ArticuloId = objArticulo.ArticuloId;
            correcto = !objDVentaDat.SelectDVentaPorArticuloId(objDVentaT);

            if (!correcto)
            {
                objArticulo.Estado = 2;
                return;
            }

            //eliminacion de Articulo en tabla
            objArticuloDat.DeleteArticulo(objArticulo);
            objArticulo.Estado = 99;
        }

        public bool LeerArticulo(Articulo objArticulo)
        {
            return objArticuloDat.SelectArticulo(objArticulo);
        }

        public DataSet LeerArticulos()
        {
            return objArticuloDat.SelectArticulos();
        }
    }
}
