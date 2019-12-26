using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgDominio
{
    public class Articulo
    {
        private string articuloId;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private double precio;
        private byte[] imagen;
        private string uMedidaId;
        private int estado;

        public string ArticuloId
        {
            get
            {
                return articuloId;
            }

            set
            {
                articuloId = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public byte[] Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public string UMedidaId
        {
            get
            {
                return uMedidaId;
            }

            set
            {
                uMedidaId = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public Articulo()
        {
            ArticuloId = "";
            Nombre = "";
            Descripcion = "";
            Cantidad = 0;
            Precio = 0;
            Imagen = new byte[] { 0 };
            UMedidaId = "";
        }

        public Articulo(string aId, string nom, string des, int can, double pre, byte[] img, string uMe)
        {
            ArticuloId = aId;
            Nombre = nom;
            Descripcion = des;
            Cantidad = can;
            Precio = pre;
            Imagen = img;
            UMedidaId = uMe;
        }
        
    }
}
