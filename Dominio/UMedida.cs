using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgDominio
{
    public class UMedida
    {
        private string uMedidaId;
        private string nombre;
        private string descripcion;
        private int estado;

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

        public UMedida()
        {
            UMedidaId = "";
            Nombre = "";
            Descripcion = "";
        }

        public UMedida(string cod, string nom, string des)
        {
            UMedidaId = cod;
            Nombre = nom;
            Descripcion = des;
        }
    }
}
