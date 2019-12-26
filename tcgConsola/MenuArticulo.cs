using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgConsola
{
    class MenuArticulo
    {
        static void Main(string[] args)
        {
            int opcion;
            char cOpcion;
            ArticuloCon objArticuloCon = new ArticuloCon();
            do
            {
                Console.Clear();
                Console.WriteLine("ADMINISTRACION DE Articulo");
                Console.WriteLine("==========================");
                Console.WriteLine("1. Registrar");
                Console.WriteLine("2. Actualizar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Consultar");
                Console.WriteLine("5. Listar");
                Console.WriteLine("6. Salir");
                Console.Write("\n\tSeleccione Operacion: ");

                cOpcion = Console.ReadKey().KeyChar;
                if (char.IsDigit(cOpcion))
                    opcion = int.Parse(cOpcion.ToString());
                else
                    opcion = -1;

                switch (opcion)
                {
                    case 1:
                        objArticuloCon.IngresarArticulo();
                        break;
                    case 2:
                        objArticuloCon.ActualizarArticulo();
                        break;
                    case 3:
                        objArticuloCon.EliminarArticulo();
                        break;
                    case 4:
                        objArticuloCon.ConsultarArticulo();
                        break;
                    case 5:
                        objArticuloCon.ListarArticulo();
                        break;
                    default:
                        if (opcion != 6)
                        {
                            Console.WriteLine("\n\nElija operación correcta...");
                            Console.WriteLine("===========================");
                            Console.Write("Pulse una tecla para continuar");
                            Console.ReadKey(true);
                        }
                        break;
                }

                if (opcion >= 1 && opcion <= 5)
                {
                    Console.WriteLine("============================================");
                    Console.Write("Pulse una tecla para continuar");
                    Console.ReadKey(true);
                }

            } while (opcion != 6);
        }
    }
}
