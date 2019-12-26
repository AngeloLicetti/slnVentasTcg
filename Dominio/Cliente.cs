using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgDominio
{
    public class Cliente
    {
        string clienteId;
        string apellidos;
        string nombres;
        string celular;
        string direccion;
        string email;
        byte[] imagen;
        int estado;

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

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        public Cliente()
        {
            ClienteId = "";
            Apellidos = "";
            Nombres = "";
            Celular = "";
            Direccion = "";
            Email = "";
            Imagen = new byte[] { 0 };
        }

        public Cliente(string cod, string ape, string nom, string cel, string dir, string ema, byte[] img)
        {
            ClienteId = cod;
            Apellidos = ape;
            Nombres = nom;
            Celular = cel;
            Direccion = dir;
            Email = ema;
            Imagen = img;
        }
    }
}
