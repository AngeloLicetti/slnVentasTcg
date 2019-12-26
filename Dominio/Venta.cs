using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgDominio
{
    public class Venta
    {
        string ventaId;
        DateTime fecha;
        string comentario;
        string clienteId;
        string trabajadorId;
        int estado;

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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Comentario
        {
            get
            {
                return comentario;
            }

            set
            {
                comentario = value;
            }
        }

        public string ClienteId
        {
            get
            {
                return clienteId;
            }

            set
            {
                clienteId = value;
            }
        }

        public string TrabajadorId
        {
            get
            {
                return trabajadorId;
            }

            set
            {
                trabajadorId = value;
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

        public Venta()
        {
            VentaId = "";
            Fecha = DateTime.Now;
            Comentario = "";
            ClienteId = "";
            TrabajadorId = "";
        }

        public Venta(string cod, DateTime fec, string com, string cli, string tra)
        {
            VentaId = cod;
            Fecha = fec;
            Comentario = com;
            ClienteId = cli;
            TrabajadorId = tra;
        }
    }
}
