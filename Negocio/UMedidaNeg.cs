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
    public class UMedidaNeg
    {
        UMedidaDat objUMedidaDat;
        ArticuloDat objArticuloDat;
        public UMedidaNeg()
        {
            objUMedidaDat = new UMedidaDat();
            objArticuloDat = new ArticuloDat();
        }
        public void RegistrarUMedida(UMedida objUMedida)
        {
            bool correcto = true;
            //codigo de UMedida: digitos significativos: entre 10001 y 99999; error = 1
            int nCodigo;
            try
            {
                nCodigo = int.Parse(objUMedida.UMedidaId);
                correcto = nCodigo >= 10000 && nCodigo < 100000;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objUMedida.Estado = 1;
                return;
            }
            //Nombre: entre 5 caracter significativo y 20; error = 2
            string sNombre = objUMedida.Nombre.Trim();
            correcto = sNombre.Length > 4 && sNombre.Length < 21;
            if (!correcto)
            {
                objUMedida.Estado = 2;
                return;
            }
            objUMedida.Nombre = sNombre;
            //Descripcion: entre 1 caracter significativo y 40; error 3
            string sDescripcion = objUMedida.Descripcion.Trim();
            correcto = sDescripcion.Length > 0 && sDescripcion.Length < 41;
            if (!correcto)
            {
                objUMedida.Estado = 3;
                return;
            }
            objUMedida.Descripcion = sDescripcion;
            //Verificar duplicidad: error = 22
            UMedida objUMedidaT = new UMedida();
            objUMedidaT.UMedidaId = objUMedida.UMedidaId;
            correcto = !objUMedidaDat.SelectUMedida(objUMedidaT);
            if (!correcto)
            {
                objUMedida.Estado = 22;
                return;
            }
            //registro de la UMedida en la tabla
            objUMedidaDat.InsertUMedida(objUMedida);
            objUMedida.Estado = 99;
        }
        public void ActualizarUMedida(UMedida objUMedida)
        {
            bool correcto = true;
            //Verificar que UMedida exista, error = 1
            UMedida objUMedidaT = new UMedida();
            objUMedidaT.UMedidaId = objUMedida.UMedidaId;
            correcto = objUMedidaDat.SelectUMedida(objUMedidaT);

            if (!correcto)
            {
                objUMedida.Estado = 1;
                return;
            }
            //SE PUEDE CREAR UN METODO PARA HACER LO QUE SIGUE Y NO REPETIRLO!
            //Nombre: entre 5 caracter significativo y 20; error = 2
            string sNombre = objUMedida.Nombre.Trim();
            correcto = sNombre.Length > 4 && sNombre.Length < 21;
            if (!correcto)
            {
                objUMedida.Estado = 2;
                return;
            }
            objUMedida.Nombre = sNombre;
            //Descripcion: entre 1 caracter significativo y 40; error 3
            string sDescripcion = objUMedida.Descripcion.Trim();
            correcto = sDescripcion.Length > 0 && sDescripcion.Length < 41;
            if (!correcto)
            {
                objUMedida.Estado = 3;
                return;
            }
            objUMedida.Descripcion = sDescripcion;
            
            //registro de actualizacion de UMedida en tabla
            objUMedidaDat.UpdateUMedida(objUMedida);
            objUMedida.Estado = 99;
        }
        public void EliminarUMedida(UMedida objUMedida)
        {
            bool correcto = true;
            //Verificar que UMedida exista, error = 1
            UMedida objUMedidaT = new UMedida();
            objUMedidaT.UMedidaId = objUMedida.UMedidaId;
            correcto = objUMedidaDat.SelectUMedida(objUMedidaT);

            if (!correcto)
            {
                objUMedida.Estado = 1;
                return;
            }

            //VERIFICAR QUE NO TENGA HIJOS EN Articulo!
            Articulo objArticuloT = new Articulo();
            objArticuloT.UMedidaId = objUMedida.UMedidaId;
            correcto = !objArticuloDat.SelectArticuloPorUMedidaId(objArticuloT);

            if (!correcto)
            {
                objUMedida.Estado = 2;
                return;
            }

            //eliminacion de UMedida en tabla
            objUMedidaDat.DeleteUMedida(objUMedida);
            objUMedida.Estado = 99;
        }

        public bool LeerUMedida(UMedida objUMedida)
        {
            return objUMedidaDat.SelectUMedida(objUMedida);
        }

        public DataSet LeerUMedidas()
        {
            return objUMedidaDat.SelectUMedidas();
        }
    }
}
