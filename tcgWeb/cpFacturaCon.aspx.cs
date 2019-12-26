using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tcgDominio;
using tcgNegocio;
using tcgGestionDatos;

public partial class cpFacturaCon : System.Web.UI.Page
{
    Venta objVenta;
    VentaNeg objVentaNeg;
    //EstadoConsultar estado;
    protected void Page_Load(object sender, EventArgs e)
    {
        objVentaNeg = new VentaNeg();
        objVenta = new Venta();
        if (!Page.IsPostBack)
        {
            //estado = EstadoEliminar.Buscar;
            ocultar();
            mjeInicial();
        }
    }

    private void mjeInicial()
    {
        lblMje.ForeColor = System.Drawing.Color.Blue;
        lblMje.Text = "Ingrese  el cógido de la Venta y presione el botón Buscar";
    }

    private void ocultar()
    {
        txtNumero.Enabled = true;
        divOcultar.Visible = false;
        btnConsultar.Text = "Buscar";
        btnRetornar.Text = "Salir";
    }

    private void visualizar()
    {
        txtNumero.Enabled = false;
        divOcultar.Visible = true;
        btnConsultar.Enabled = false;
        btnRetornar.Text = "Retornar";
    }

    private void cargarVenta()
    {
        txtNumero.Text = objVenta.VentaId.ToString();
        txtComentario.Text = objVenta.Comentario;
        cldFecha.SelectedDate = objVenta.Fecha.Date;
        txtCliente.Text = nombreDelCliente();
        txtTrabajador.Text = nombreDelTrabajador();
    }

    private string nombreDelCliente()
    {
        Cliente objCliente = new Cliente();
        objCliente.ClienteId = objVenta.ClienteId;
        ClienteDat objCllienteDat = new ClienteDat();
        objCllienteDat.SelectCliente(objCliente);
        return objCliente.Nombres + " " + objCliente.Apellidos;
    }

    private string nombreDelTrabajador()
    {
        Trabajador objTrabajador = new Trabajador();
        objTrabajador.TrabajadorId = objVenta.TrabajadorId;
        TrabajadorDat objTrabajadorDat = new TrabajadorDat();
        objTrabajadorDat.SelectTrabajador(objTrabajador);
        return objTrabajador.Nombres + " " + objTrabajador.Apellidos;
    }

    private void mostraMjeBuscar(Venta objVenta)
    {
        lblMje.ForeColor = objVenta.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        if (objVenta.Estado == 99)
        {
            lblMje.Text = "Estos son los datos; visualize y pulse Retornar.";
        }
        else
        {
            lblMje.Text = "Venta [" + objVenta.VentaId + "] NO EXISTE.";
        }
    }

    protected void btnRetornar_Click(object sender, EventArgs e)
    {
        if (txtNumero.Enabled == true)
        {
            //completar
            string close = @"<script type='text/javascript' >
                            window.open('','_parent','');
                            window.close();
                        </script>";
            Response.Write(close);
        }
        else
        {
            ocultar();
            mjeInicial();
            //estado = EstadoEliminar.Buscar;
            btnBorrar.Enabled = true;
            btnConsultar.Enabled = true;
        }
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtNumero.Text = "";
    }



    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        objVenta = new Venta();
        objVenta.VentaId = txtNumero.Text;
        objVentaNeg.LeerVenta(objVenta);
        mostraMjeBuscar(objVenta);
        if (objVenta.Estado == 99)
        {
            cargarVenta();
            visualizar();
            //estado = EstadoConsultar.Consultar;
            btnBorrar.Enabled = false;
        }
    }
}