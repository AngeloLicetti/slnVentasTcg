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
    public class UMedidaDat
    {
        SqlConnection conexion;

        public UMedidaDat()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public void InsertUMedida(UMedida objUMedida)
        {
            string Insertar = "INSERT UMedida(UMedidaId, Nombre, Descripcion) VALUES('" + objUMedida.UMedidaId + "','" + objUMedida.Nombre + "','" + objUMedida.Descripcion + "')";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }
        public void UpdateUMedida(UMedida objUMedida)
        {
            string Insertar = "UPDATE UMedida SET Nombre = '" + objUMedida.Nombre + "' , Descripcion = '" + objUMedida.Descripcion + "' WHERE UMedidaId = '" + objUMedida.UMedidaId + "'";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }
        public void DeleteUMedida(UMedida objUMedida)
        {
            string Insertar = "DELETE UMedida WHERE UMedidaId = '" + objUMedida.UMedidaId + "' ";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public bool SelectUMedida(UMedida objUMedida)
        {
            string select = "SELECT * FROM UMedida WHERE UMedidaId ='" + objUMedida.UMedidaId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objUMedida.Nombre = (string)reader[1];
                objUMedida.Descripcion = (string)reader[2];
                objUMedida.Estado = 99;
            }
            else
            {
                objUMedida.Estado = 1;
            }
            conexion.Close();
            return hayRegistros;
        }

        public DataSet SelectUMedidas()
        {
            DataSet dsUMedidas = new DataSet();
            string select = "SELECT * FROM UMedida";
            SqlDataAdapter unComando = new SqlDataAdapter(select, conexion);
            unComando.Fill(dsUMedidas, "UMedidas");
            return dsUMedidas;
        }
    }
}
