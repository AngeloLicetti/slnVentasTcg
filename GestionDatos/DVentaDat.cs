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
    public class DVentaDat
    {
        SqlConnection conexion;

        public DVentaDat()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public void InsertDVenta(DVenta objDVenta)
        {
            string Insertar = "INSERT DVenta(DVentaId, Cantidad, Precio, VentaId, ArticuloId) VALUES('" + objDVenta.DVentaId  + "','" + objDVenta.Cantidad + "','" + objDVenta.Precio + "','" + objDVenta.VentaId + "','" + objDVenta.ArticuloId + "')";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateDVenta(DVenta objDVenta)
        {
            string Insertar = "UPDATE DVenta SET Cantidad = '" + objDVenta.Cantidad + "', Precio = '" + objDVenta.Precio + "' , VentaId = '" + objDVenta.VentaId + "' , ArticuloId = '" + objDVenta.ArticuloId + "' WHERE DVentaId = '" + objDVenta.DVentaId + "'";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void DeleteDVenta(DVenta objDVenta)
        {
            string Insertar = "DELETE DVenta WHERE DVentaId = '" + objDVenta.DVentaId + "' ";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public bool SelectDVenta(DVenta objDVenta)
        {
            string select = "SELECT * FROM DVenta WHERE DVentaId ='" + objDVenta.DVentaId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objDVenta.Cantidad = (int)reader[1];
                objDVenta.Precio = reader.GetDouble(2);
                objDVenta.VentaId = (string)reader[3];
                objDVenta.ArticuloId = (string)reader[4];
                objDVenta.Estado = 99;
            }
            else
            {
                objDVenta.Estado = 1;
            }
            conexion.Close();
            return hayRegistros;
        }

        public DataSet SelectDVentas()
        {
            DataSet dsDVentas = new DataSet();
            string select = "SELECT * FROM DVenta";
            SqlDataAdapter unComando = new SqlDataAdapter(select, conexion);
            unComando.Fill(dsDVentas, "DVentas");
            return dsDVentas;
        }

        public bool SelectDVentaPorVentaId(DVenta objDVenta)
        {
            string select = "SELECT * FROM DVENTA WHERE VentaId ='" + objDVenta.VentaId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objDVenta.DVentaId = (string)reader[0];
                objDVenta.Cantidad = (int)reader[1];
                objDVenta.Precio = reader.GetDouble(2);
                objDVenta.ArticuloId = (string)reader[4];
                objDVenta.Estado = 99;
            }
            else
            {
                objDVenta.Estado = 22;
            }
            conexion.Close();
            return hayRegistros;
        }

        public bool SelectDVentaPorArticuloId(DVenta objDVenta)
        {
            string select = "SELECT * FROM DVENTA WHERE ArticuloId ='" + objDVenta.ArticuloId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objDVenta.DVentaId = (string)reader[0];
                objDVenta.Cantidad = (int)reader[1];
                objDVenta.Precio = reader.GetDouble(2);
                objDVenta.VentaId = (string)reader[3];
                objDVenta.Estado = 99;
            }
            else
            {
                objDVenta.Estado = 22;
            }
            conexion.Close();
            return hayRegistros;
        }
    }
}
