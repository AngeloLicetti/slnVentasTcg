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
    public class VentaDat
    {
        SqlConnection conexion;

        public VentaDat()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public void InsertVenta(Venta objVenta)
        {
            string Insertar = "INSERT Venta(VentaId, Fecha, Comentario, ClienteId, TrabajadorId) VALUES('" + objVenta.VentaId + "','" + objVenta.Fecha.Date.ToString("yyyy-dd-MM HH:mm:ss") + "','" + objVenta.Comentario + "','" + objVenta.ClienteId + "','" + objVenta.TrabajadorId + "')";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateVenta(Venta objVenta)
        {
            string Insertar = "UPDATE Venta SET Fecha = '" + objVenta.Fecha.Date.ToString("yyyy-dd-MM HH:mm:ss") + "', Comentario = '" + objVenta.Comentario + "' , ClienteId = '" + objVenta.ClienteId + "' , TrabajadorId = '" + objVenta.TrabajadorId + "' WHERE VentaId = '" + objVenta.VentaId + "'";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public void DeleteVenta(Venta objVenta)
        {
            string Insertar = "DELETE Venta WHERE VentaId = '" + objVenta.VentaId + "' ";
            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }

        public bool SelectVenta(Venta objVenta)
        {
            string select = "SELECT * FROM Venta WHERE VentaId ='" + objVenta.VentaId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objVenta.Fecha = (DateTime)reader[1];
                objVenta.Comentario = (string)reader[2];
                objVenta.ClienteId = (string)reader[3];
                objVenta.TrabajadorId = (string)reader[4];
                objVenta.Estado = 99;
            }
            else
            {
                objVenta.Estado = 1;
            }
            conexion.Close();
            return hayRegistros;
        }

        public DataSet SelectVentas()
        {
            DataSet dsVentas = new DataSet();
            string select = "SELECT * FROM Venta";
            SqlDataAdapter unComando = new SqlDataAdapter(select, conexion);
            unComando.Fill(dsVentas, "Ventas");
            return dsVentas;
        }

        public bool SelectVentaPorClienteId(Venta objVenta)
        {
            string select = "SELECT * FROM Venta WHERE ClienteId ='" + objVenta.ClienteId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objVenta.VentaId = (string)reader[0];
                objVenta.Fecha = (DateTime)reader[1];
                objVenta.Comentario = (string)reader[2];
                objVenta.TrabajadorId = (string)reader[4];
                objVenta.Estado = 99;
            }
            else
            {
                objVenta.Estado = 22;
            }
            conexion.Close();
            return hayRegistros;
        }

        public bool SelectVentaPorTrabajadorId(Venta objVenta)
        {
            string select = "SELECT * FROM Venta WHERE TrabajadorId ='" + objVenta.TrabajadorId + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objVenta.VentaId = (string)reader[0];
                objVenta.Fecha = (DateTime)reader[1];
                objVenta.Comentario = (string)reader[2];
                objVenta.ClienteId = (string)reader[3];
                objVenta.Estado = 99;
            }
            else
            {
                objVenta.Estado = 22;
            }
            conexion.Close();
            return hayRegistros;
        }
    }
}
