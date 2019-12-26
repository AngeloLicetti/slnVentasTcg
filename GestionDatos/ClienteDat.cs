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
    public class ClienteDat
    {
        SqlConnection conexion;

        public ClienteDat()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public void InsertCliente(Cliente objCliente)
        {
            string Insertar = "INSERT Cliente(ClienteId, Apellidos, Nombres, Celular, Direccion, Email, Imagen) VALUES('" + objCliente.ClienteId + "','" + objCliente.Apellidos + "','" + objCliente.Nombres + "','" + objCliente.Celular + "','" + objCliente.Direccion + "','" + objCliente.Email + "', CONVERT(VARBINARY(8000), '" + objCliente.Imagen + "'))";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateCliente(Cliente objCliente)
        {
            string Insertar = "UPDATE Cliente SET Apellidos = '" + objCliente.Apellidos + "' , Nombres = '" + objCliente.Nombres + "' , Celular = '" + objCliente.Celular + "' , Direccion = '" + objCliente.Direccion + "' , Email = '" + objCliente.Email + "' , Imagen = CONVERT(VARBINARY(8000), '" + objCliente.Imagen + "') WHERE ClienteId = '" + objCliente.ClienteId + "'";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void DeleteCliente(Cliente objCliente)
        {
            string Insertar = "DELETE Cliente WHERE ClienteId = '" + objCliente.ClienteId + "' ";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public bool SelectCliente(Cliente objCliente)
        {
            string select = "SELECT * FROM Cliente WHERE ClienteId ='" + objCliente.ClienteId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objCliente.Apellidos = (string)reader[1];
                objCliente.Nombres = (string)reader[2];
                objCliente.Celular = (string)reader[3];
                objCliente.Direccion = (string)reader[4];
                objCliente.Email = (string)reader[5];
                objCliente.Imagen = (byte[])reader[6];
                objCliente.Estado = 99;
            }
            else
            {
                objCliente.Estado = 1;
            }
            conexion.Close();
            return hayRegistros;
        }

        public DataSet SelectClientes()
        {
            DataSet dsClientes = new DataSet();
            string select = "SELECT * FROM Cliente";
            SqlDataAdapter unComando = new SqlDataAdapter(select, conexion);
            unComando.Fill(dsClientes, "Clientes");
            return dsClientes;
        }
    }
}
