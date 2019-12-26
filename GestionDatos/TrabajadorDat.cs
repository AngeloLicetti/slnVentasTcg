using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using tcgDominio;

namespace tcgGestionDatos
{
    public class TrabajadorDat
    {
        SqlConnection conexion;

        public TrabajadorDat()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public void InsertTrabajador(Trabajador objTrabajador)
        {
            string Insertar = "INSERT Trabajador(TrabajadorId, Apellidos, Nombres, Cargo, Dni, Celular, Direccion, Email, Imagen) VALUES('" + objTrabajador.TrabajadorId + "','" + objTrabajador.Apellidos + "','" + objTrabajador.Nombres + "','" + objTrabajador.Cargo + "','" + objTrabajador.Dni + "','" + objTrabajador.Celular + "','" + objTrabajador.Direccion + "','" + objTrabajador.Email + "', CONVERT(VARBINARY(8000), '" + objTrabajador.Imagen + "'))";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateTrabajador(Trabajador objTrabajador)
        {
            string Insertar = "UPDATE Trabajador SET Apellidos = '" + objTrabajador.Apellidos + "' , Nombres = '" + objTrabajador.Nombres + "' , Cargo = '" + objTrabajador.Cargo + "', Dni = '" + objTrabajador.Dni + "' , Celular = '" + objTrabajador.Celular + "' , Direccion = '" + objTrabajador.Direccion + "' , Email = '" + objTrabajador.Email + "' , Imagen = CONVERT(VARBINARY(8000), '" + objTrabajador.Imagen + "') WHERE TrabajadorId = '" + objTrabajador.TrabajadorId + "'";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void DeleteTrabajador(Trabajador objTrabajador)
        {
            string Insertar = "DELETE Trabajador WHERE TrabajadorId = '" + objTrabajador.TrabajadorId + "' ";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public bool SelectTrabajador(Trabajador objTrabajador)
        {
            string select = "SELECT * FROM Trabajador WHERE TrabajadorId ='" + objTrabajador.TrabajadorId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objTrabajador.Apellidos = (string)reader[1];
                objTrabajador.Nombres = (string)reader[2];
                objTrabajador.Cargo = (string)reader[3];
                objTrabajador.Dni = (string)reader[4];
                objTrabajador.Celular = (string)reader[5];
                objTrabajador.Direccion = (string)reader[6];
                objTrabajador.Email = (string)reader[7];
                objTrabajador.Imagen = (byte[])reader[8];
                objTrabajador.Estado = 99;
            }
            else
            {
                objTrabajador.Estado = 1;
            }
            conexion.Close();
            return hayRegistros;
        }

        public DataSet SelectTrabajadors()
        {
            DataSet dsTrabajadors = new DataSet();
            string select = "SELECT * FROM Trabajador";
            SqlDataAdapter unComando = new SqlDataAdapter(select, conexion);
            unComando.Fill(dsTrabajadors, "Trabajadors");
            return dsTrabajadors;
        }
    }
}
