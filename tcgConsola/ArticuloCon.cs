using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using tcgDominio;
using tcgNegocio;

namespace tcgConsola
{
    public class ArticuloCon
    {
        Articulo objArticulo;
        ArticuloNeg objArticuloNeg;
        public ArticuloCon()
        {
            objArticuloNeg = new ArticuloNeg();
        }
        public void IngresarArticulo()
        {
            objArticulo = new Articulo();
            Console.WriteLine("\n\nINGRESO DE Articulo");
            Console.WriteLine("==================\n");

            Console.Write("Codigo: ");
            objArticulo.ArticuloId = Console.ReadLine();

            Console.Write("Nombre: ");
            objArticulo.Nombre = Console.ReadLine();

            Console.Write("Descripcion: ");
            objArticulo.Descripcion = Console.ReadLine();

            Console.Write("Cantidad: ");
            try
            {
                objArticulo.Cantidad = int.Parse(Console.ReadLine());
            }
            catch
            {
                objArticulo.Estado = 4;
                mostrarMjeRegistrar(objArticulo);
                return;
            }
            Console.Write("Precio: ");
            try
            {
                objArticulo.Precio = float.Parse(Console.ReadLine());
            }
            catch
            {
                objArticulo.Estado = 5;
                mostrarMjeRegistrar(objArticulo);
                return;
            }

            objArticulo.Imagen = new byte[] { 0 };

            Console.Write("UMedidaId: ");
            objArticulo.UMedidaId = Console.ReadLine();

            objArticuloNeg.RegistrarArticulo(objArticulo);
            mostrarMjeRegistrar(objArticulo);
        }
        public void ActualizarArticulo()
        {
            objArticulo = new Articulo();
            Console.WriteLine("\n\nACTUALIZACION DE Articulo");
            Console.WriteLine("==================\n");

            Console.Write("Codigo: ");
            objArticulo.ArticuloId = Console.ReadLine();

            Console.Write("Nombre: ");
            objArticulo.Nombre = Console.ReadLine();

            Console.Write("Descripcion: ");
            objArticulo.Descripcion = Console.ReadLine();

            Console.Write("Cantidad: ");
            try
            {
                objArticulo.Cantidad = int.Parse(Console.ReadLine());
            }
            catch
            {
                objArticulo.Estado = 4;
                mostrarMjeRegistrar(objArticulo);
                return;
            }
            Console.Write("Precio: ");
            try
            {
                objArticulo.Precio = float.Parse(Console.ReadLine());
            }
            catch
            {
                objArticulo.Estado = 5;
                mostrarMjeRegistrar(objArticulo);
                return;
            }

            objArticulo.Imagen = new byte[] { 0 };

            Console.Write("UMedida: ");
            objArticulo.UMedidaId = Console.ReadLine();

            objArticuloNeg.ActualizarArticulo(objArticulo);
            mostrarMjeActualizar(objArticulo);

        }
        public void EliminarArticulo()
        {
            objArticulo = new Articulo();
            Console.WriteLine("\n\nELIMINACION DE Articulo");
            Console.WriteLine("==================\n");

            Console.Write("Codigo: ");
            objArticulo.ArticuloId = Console.ReadLine();
            objArticuloNeg.EliminarArticulo(objArticulo);
            mostrarMjeEliminar(objArticulo);
        }
        public void ConsultarArticulo()
        {
            objArticulo = new Articulo();
            Console.WriteLine("\n\nCONSULTA DE Articulo");
            Console.WriteLine("==================\n");

            Console.Write("Codigo: ");
            objArticulo.ArticuloId = Console.ReadLine();

            if (objArticuloNeg.LeerArticulo(objArticulo))
            {
                Console.WriteLine();
                Console.WriteLine("Nombre: " + objArticulo.Nombre);
                Console.WriteLine();
                Console.WriteLine("Descripcion: " + objArticulo.Descripcion);
                Console.WriteLine();
                Console.WriteLine("Cantidad: " + objArticulo.Cantidad);
                Console.WriteLine();
                Console.WriteLine("Precio: " + objArticulo.Precio);
                Console.WriteLine();
                Console.WriteLine("UMedidaId: " + objArticulo.UMedidaId);
            }
            else Console.WriteLine("\n Articulo NO EXISTE \n");
        }
        public void ListarArticulo()
        {
            Console.WriteLine("\n\nLISTADO DE ArticuloS");
            Console.WriteLine("{0,-10} {1,-30} {2, -60} {3,-10} {4,-10} {5, -10}", "COD", "Nombre", "Descripcion", "Cantidad", "Precio", "UMedidaId");
            Console.WriteLine("========== ============================== ============================== ========== ===========");

            DataSet dsArticulos = objArticuloNeg.LeerArticulos();

            if (dsArticulos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in dsArticulos.Tables[0].Rows)
                {
                    Console.WriteLine("{0,-10} {1,-30} {2, -60} {3,-10} {4,-10} {5, -10}", fila[0], fila[1], fila[2], fila[3], fila[4], fila[6]);
                }
            }
            else Console.WriteLine("\n NO EXISTEN ArticuloS ");
        }

        private void mostrarMjeRegistrar(Articulo objC)
        {
            Console.WriteLine("==================");
            switch (objC.Estado)
            {
                case 2: //error de Nombre
                    Console.WriteLine("El Nombre deben tener enre 5 y 30 caracteres");
                    break;
                case 3: //error de Descripcion
                    Console.WriteLine("La Descripcion debe tener entre 1 y 50 caracteres");
                    break;
                case 4: //error de Cantidad
                    Console.WriteLine("La cantidad debe ser mayor o igual a 0");
                    break;
                case 5: //error de Precio
                    Console.WriteLine("El precio debe ser mayor o igual a 0");
                    break;
                case 6: //error de Imagen
                    Console.WriteLine("Error de imagen");
                    break;
                case 7: //error de UMedidaId
                    Console.WriteLine("La UMedida: [" + objC.UMedidaId + "] no existe");
                    break;
                case 22: //Articulo duplicada
                    Console.WriteLine("Articulo [" + objC.ArticuloId + "] DUPLICADO...");
                    break;
                case 99: //Articulo registrado correctamente
                    Console.WriteLine("El Articulo [" + objC.ArticuloId + "] SE REGISTRO EXITOSAMENTE...");
                    break;
                default:
                    Console.WriteLine("===???===");
                    break;
            }
        }
        private void mostrarMjeActualizar(Articulo objC)
        {
            Console.WriteLine("==================");
            switch (objC.Estado)
            {
                case 1: //error de codigo
                    Console.WriteLine("Cliente [" + objC.ArticuloId + "] NO EXISTE ...");
                    break;
                case 2: //error de Nombre
                    Console.WriteLine("El Nombre deben tener enre 5 y 30 caracteres");
                    break;
                case 3: //error de Descripcion
                    Console.WriteLine("La Descripcion debe tener entre 1 y 50 caracteres");
                    break;
                case 4: //error de Cantidad
                    Console.WriteLine("La cantidad debe ser mayor o igual a 0");
                    break;
                case 5: //error de Precio
                    Console.WriteLine("El precio debe ser mayor o igual a 0");
                    break;
                case 6: //error de Imagen
                    Console.WriteLine("Error de imagen");
                    break;
                case 7: //error de UMedidaId
                    Console.WriteLine("La UMedida: [" + objC.UMedidaId + "] no existe");
                    break;
                case 99: //Articulo actualizado correctamente
                    Console.WriteLine("El Articulo [" + objC.ArticuloId + "] SE ACTUALIZÓ EXITOSAMENTE...");
                    break;
                default:
                    Console.WriteLine("===???===");
                    break;
            }
        }
        private void mostrarMjeEliminar(Articulo objC)
        {
            Console.WriteLine("==================");
            switch (objC.Estado)
            {
                case 1: //error de codigo
                    Console.WriteLine("Articulo [" + objC.ArticuloId + "] NO EXISTE ...");
                    break;
                case 2: //Articulo tiene hijos
                    Console.WriteLine("Articulo [" + objC.ArticuloId + "] tiene hijos, NO se puede eliminar");
                    break;
                case 99: //Articulo registrada correctamente
                    Console.WriteLine("Eñ Articulo [" + objC.ArticuloId + "] SE ELIMINÓ EXITOSAMENTE...");
                    break;
                default:
                    Console.WriteLine("===???===");
                    break;
            }
        }
    }
}
