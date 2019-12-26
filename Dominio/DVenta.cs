using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgDominio
{
    public class DVenta
    {
        private string dVentaId;
        private int cantidad;
        private double precio;
        private string ventaId;
        private string articuloId;
        private int estado;

        public string DVentaId
        {
            get
            {
                return dVentaId;
            }

            set
            {
                dVentaId = value;
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

        public string VentaId
        {
            get
            {
                return ventaId;
            }

            set
            {
                ventaId = value;
            }
        }

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

        public DVenta()
        {
            DVentaId = "";
            Cantidad = 0;
            Precio = 0;
            VentaId = "";
            ArticuloId = "";
        }

        public DVenta(string dId, int can, double pre, string vId, string aId)
        {
            DVentaId = dId;
            Cantidad = can;
            Precio = pre;
            VentaId = vId;
            ArticuloId = aId;
        }
        
    }
}
