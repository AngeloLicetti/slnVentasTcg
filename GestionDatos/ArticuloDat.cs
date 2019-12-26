using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using tcgDominio;
using System.Data.SqlTypes;

namespace tcgGestionDatos
{
    public class ArticuloDat
    {
        SqlConnection conexion;

        public ArticuloDat()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public void InsertArticulo(Articulo objArticulo)
        {
            string Insertar = "INSERT Articulo(ArticuloId, Nombre, Descripcion, Cantidad, Precio, Imagen, UMedidaId) VALUES('" + objArticulo.ArticuloId + "','" + objArticulo.Nombre + "','" + objArticulo.Descripcion + "','" + objArticulo.Cantidad + "','" + objArticulo.Precio + "', CONVERT(VARBINARY(8000), '" + objArticulo.Imagen + "') ,'" + objArticulo.UMedidaId + "')";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateArticulo(Articulo objArticulo)
        {
            string Insertar = "UPDATE Articulo SET Nombre = '" + objArticulo.Nombre + "' , Descripcion = '" + objArticulo.Descripcion + "' , Cantidad = '" + objArticulo.Cantidad + "', Precio = '" + objArticulo.Precio + "' , Imagen = CONVERT(VARBINARY(8000), '" + objArticulo.Imagen + "') , UMedidaId = '" + objArticulo.UMedidaId + "' WHERE ArticuloId = '" + objArticulo.ArticuloId + "'";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void DeleteArticulo(Articulo objArticulo)
        {
            string Insertar = "DELETE Articulo WHERE ArticuloId = '" + objArticulo.ArticuloId + "' ";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public bool SelectArticulo(Articulo objArticulo)
        {
            string select = "SELECT * FROM Articulo WHERE ArticuloId ='" + objArticulo.ArticuloId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objArticulo.Nombre = (string)reader[1];
                objArticulo.Descripcion = (string)reader[2];
                objArticulo.Cantidad = (int)reader[3];
                objArticulo.Precio = reader.GetDouble(4);
                objArticulo.Imagen = (byte[])reader[5];
                objArticulo.UMedidaId = (string)reader[6];
                objArticulo.Estado = 99;
            }
            else
            {
                objArticulo.Estado = 1;
            }
            conexion.Close();
            return hayRegistros;
        }

        public DataSet SelectArticulos()
        {
            DataSet dsArticulos = new DataSet();
            string select = "SELECT * FROM Articulo";
            SqlDataAdapter unComando = new SqlDataAdapter(select, conexion);
            unComando.Fill(dsArticulos, "Articulos");
            return dsArticulos;
        }

        public bool SelectArticuloPorUMedidaId(Articulo objArticulo)
        {
            string select = "SELECT * FROM Articulo WHERE UMedidaId ='" + objArticulo.UMedidaId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objArticulo.ArticuloId = (string)reader[0];
                objArticulo.Nombre = (string)reader[1];
                objArticulo.Descripcion = (string)reader[2];
                objArticulo.Cantidad = (int)reader[3];
                objArticulo.Precio = reader.GetDouble(4);
                objArticulo.Imagen = (byte[])reader[5];
                objArticulo.Estado = 99;
            }
            else
            {
                objArticulo.Estado = 22;
            }
            conexion.Close();
            return hayRegistros;
        }
    }
}
