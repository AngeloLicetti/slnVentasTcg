using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tcgDominio;
using tcgNegocio;
using tcgGestionDatos;
using System.Data;

public partial class cpFacturaEli : System.Web.UI.Page
{
    Venta objVenta;
    VentaNeg objVentaNeg;
    //EstadoEliminar estado;

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
        btnEliminar.Text = "Buscar";
        btnRetornar.Text = "Salir";
    }

    private void visualizar()
    {
        txtNumero.Enabled = false;
        divOcultar.Visible = true;
        btnEliminar.Text = "Eliminar";
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
            lblMje.Text = "Estos son los datos; visualize y si está seguro que desea eliminarlo pulse Eliminar.";
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
        }
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtNumero.Text = "";
    }

    private void mostrarMjeELiminar(Venta objVenta)
    {
        lblMje.ForeColor = objVenta.Estado == 99 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        switch (objVenta.Estado)
        {
            case 1: //no existe
                lblMje.Text = "La Venta [" + objVenta.VentaId + "] no existe";
                break;
            case 2: //tiene hijos en DVenta
                lblMje.Text = "La Venta [" + objVenta.VentaId + "] tiene hijos en DVenta; NO SE PUEDE ELIMINAR";
                break;
            case 99: //Venta eliminada
                lblMje.Text = "Venta " + objVenta.VentaId + " eliminada satisfactoriamente.";
                break;
            default: //
                lblMje.Text = "==???==";
                break;
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txtNumero.Enabled == true)
        {
            objVenta = new Venta();
            objVenta.VentaId = txtNumero.Text;
            objVentaNeg.LeerVenta(objVenta);
            mostraMjeBuscar(objVenta);
            if (objVenta.Estado == 99)
            {
                cargarVenta();
                visualizar();
                //estado = EstadoEliminar.Eliminar;
                btnBorrar.Enabled = false;
            }
        }
        else
        {
            objVenta = new Venta();
            objVenta.VentaId = txtNumero.Text;
            objVentaNeg.EliminarVenta(objVenta);
            mostrarMjeELiminar(objVenta);
            if (objVenta.Estado == 99)
            {
                //estado = EstadoEliminar.Buscar;
                ocultar();
                btnBorrar.Enabled = true;
            }
        }
    }
}