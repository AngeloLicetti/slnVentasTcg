using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgDominio
{
    public class Trabajador
    {
        string trabajadorId;
        string nombres;
        string apellidos;
        string cargo;
        string dni;
        string celular;
        string direccion;
        string email;
        byte[] imagen;
        int estado;

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

        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
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

        public Trabajador()
        {
            TrabajadorId = "";
            Nombres = "";
            Apellidos = "";
            Cargo = "";
            Dni = "";
            Celular = "";
            Direccion = "";
            Email = "";
            Imagen = new byte[] { 0 };
        }

        public Trabajador(string tra, string nom, string ape, string car, string dni, string cel, string dir, string ema, byte[] img)
        {
            TrabajadorId = "";
            Nombres = "";
            Apellidos = "";
            Cargo = "";
            Dni = "";
            Celular = "";
            Direccion = "";
            Email = "";
            Imagen = img;
        }
    }
}
