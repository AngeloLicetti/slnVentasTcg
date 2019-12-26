namespace tcgGUI
{
    partial class frmTcgMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSistSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuEntiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEntiClieRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEntiClieActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEntiClieEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuEntiProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuEntiTrabajador = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.uMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEntiUMedRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEntiUMedActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEntiUMedEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuRepoConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dVentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRepoConsUMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuRepoListar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRepoListClientes = new System.Windows.Forms.ToolStripComboBox();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dVentaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRepoListUMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistema,
            this.mnuEntidades,
            this.mnuMovimientos,
            this.mnuReportes,
            this.mnuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSistema
            // 
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSistSalir});
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(60, 20);
            this.mnuSistema.Text = "Sistema";
            // 
            // cmdSistSalir
            // 
            this.cmdSistSalir.Name = "cmdSistSalir";
            this.cmdSistSalir.Size = new System.Drawing.Size(96, 22);
            this.cmdSistSalir.Text = "Salir";
            this.cmdSistSalir.Click += new System.EventHandler(this.cmdSistSalir_Click);
            // 
            // mnuEntidades
            // 
            this.mnuEntidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuEntiCliente,
            this.smnuEntiProducto,
            this.smnuEntiTrabajador,
            this.ventaToolStripMenuItem,
            this.dVentaToolStripMenuItem,
            this.uMedidaToolStripMenuItem});
            this.mnuEntidades.Name = "mnuEntidades";
            this.mnuEntidades.Size = new System.Drawing.Size(70, 20);
            this.mnuEntidades.Text = "Entidades";
            // 
            // smnuEntiCliente
            // 
            this.smnuEntiCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdEntiClieRegistrar,
            this.cmdEntiClieActualizar,
            this.cmdEntiClieEliminar});
            this.smnuEntiCliente.Name = "smnuEntiCliente";
            this.smnuEntiCliente.Size = new System.Drawing.Size(131, 22);
            this.smnuEntiCliente.Text = "Cliente";
            // 
            // cmdEntiClieRegistrar
            // 
            this.cmdEntiClieRegistrar.Name = "cmdEntiClieRegistrar";
            this.cmdEntiClieRegistrar.Size = new System.Drawing.Size(126, 22);
            this.cmdEntiClieRegistrar.Text = "Registrar";
            // 
            // cmdEntiClieActualizar
            // 
            this.cmdEntiClieActualizar.Name = "cmdEntiClieActualizar";
            this.cmdEntiClieActualizar.Size = new System.Drawing.Size(126, 22);
            this.cmdEntiClieActualizar.Text = "Actualizar";
            // 
            // cmdEntiClieEliminar
            // 
            this.cmdEntiClieEliminar.Name = "cmdEntiClieEliminar";
            this.cmdEntiClieEliminar.Size = new System.Drawing.Size(126, 22);
            this.cmdEntiClieEliminar.Text = "Eliminar";
            // 
            // smnuEntiProducto
            // 
            this.smnuEntiProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.actualizarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.smnuEntiProducto.Name = "smnuEntiProducto";
            this.smnuEntiProducto.Size = new System.Drawing.Size(131, 22);
            this.smnuEntiProducto.Text = "Articulo";
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            this.registrarToolStripMenuItem1.Click += new System.EventHandler(this.registrarToolStripMenuItem1_Click);
            // 
            // actualizarToolStripMenuItem1
            // 
            this.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            this.actualizarToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem1.Text = "Actualizar";
            this.actualizarToolStripMenuItem1.Click += new System.EventHandler(this.actualizarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // smnuEntiTrabajador
            // 
            this.smnuEntiTrabajador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem2,
            this.actualizarToolStripMenuItem2,
            this.eliminarToolStripMenuItem2});
            this.smnuEntiTrabajador.Name = "smnuEntiTrabajador";
            this.smnuEntiTrabajador.Size = new System.Drawing.Size(131, 22);
            this.smnuEntiTrabajador.Text = "Trabajador";
            // 
            // registrarToolStripMenuItem2
            // 
            this.registrarToolStripMenuItem2.Name = "registrarToolStripMenuItem2";
            this.registrarToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.registrarToolStripMenuItem2.Text = "Registrar";
            // 
            // actualizarToolStripMenuItem2
            // 
            this.actualizarToolStripMenuItem2.Name = "actualizarToolStripMenuItem2";
            this.actualizarToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem2.Text = "Actualizar";
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // dVentaToolStripMenuItem
            // 
            this.dVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem3,
            this.actualizarToolStripMenuItem3,
            this.eliminarToolStripMenuItem3});
            this.dVentaToolStripMenuItem.Name = "dVentaToolStripMenuItem";
            this.dVentaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dVentaToolStripMenuItem.Text = "DVenta";
            // 
            // registrarToolStripMenuItem3
            // 
            this.registrarToolStripMenuItem3.Name = "registrarToolStripMenuItem3";
            this.registrarToolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.registrarToolStripMenuItem3.Text = "Registrar";
            // 
            // actualizarToolStripMenuItem3
            // 
            this.actualizarToolStripMenuItem3.Name = "actualizarToolStripMenuItem3";
            this.actualizarToolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem3.Text = "Actualizar";
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem3.Text = "Eliminar";
            // 
            // uMedidaToolStripMenuItem
            // 
            this.uMedidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdEntiUMedRegistrar,
            this.cmdEntiUMedActualizar,
            this.cmdEntiUMedEliminar});
            this.uMedidaToolStripMenuItem.Name = "uMedidaToolStripMenuItem";
            this.uMedidaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.uMedidaToolStripMenuItem.Text = "UMedida";
            // 
            // cmdEntiUMedRegistrar
            // 
            this.cmdEntiUMedRegistrar.Name = "cmdEntiUMedRegistrar";
            this.cmdEntiUMedRegistrar.Size = new System.Drawing.Size(126, 22);
            this.cmdEntiUMedRegistrar.Text = "Registrar";
            this.cmdEntiUMedRegistrar.Click += new System.EventHandler(this.cmdEntiUMedRegistrar_Click);
            // 
            // cmdEntiUMedActualizar
            // 
            this.cmdEntiUMedActualizar.Name = "cmdEntiUMedActualizar";
            this.cmdEntiUMedActualizar.Size = new System.Drawing.Size(126, 22);
            this.cmdEntiUMedActualizar.Text = "Actualizar";
            this.cmdEntiUMedActualizar.Click += new System.EventHandler(this.cmdEntiUMedActualizar_Click);
            // 
            // cmdEntiUMedEliminar
            // 
            this.cmdEntiUMedEliminar.Name = "cmdEntiUMedEliminar";
            this.cmdEntiUMedEliminar.Size = new System.Drawing.Size(126, 22);
            this.cmdEntiUMedEliminar.Text = "Eliminar";
            this.cmdEntiUMedEliminar.Click += new System.EventHandler(this.cmdEntiUMedEliminar_Click);
            // 
            // mnuMovimientos
            // 
            this.mnuMovimientos.Name = "mnuMovimientos";
            this.mnuMovimientos.Size = new System.Drawing.Size(89, 20);
            this.mnuMovimientos.Text = "Movimientos";
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuRepoConsultar,
            this.smnuRepoListar});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(65, 20);
            this.mnuReportes.Text = "Reportes";
            // 
            // smnuRepoConsultar
            // 
            this.smnuRepoConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.productoToolStripMenuItem1,
            this.trabajadorToolStripMenuItem,
            this.ventaToolStripMenuItem1,
            this.dVentaToolStripMenuItem1,
            this.cmdRepoConsUMedida});
            this.smnuRepoConsultar.Name = "smnuRepoConsultar";
            this.smnuRepoConsultar.Size = new System.Drawing.Size(125, 22);
            this.smnuRepoConsultar.Text = "Consultar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.productoToolStripMenuItem1.Text = "Articulo";
            this.productoToolStripMenuItem1.Click += new System.EventHandler(this.productoToolStripMenuItem1_Click);
            // 
            // trabajadorToolStripMenuItem
            // 
            this.trabajadorToolStripMenuItem.Name = "trabajadorToolStripMenuItem";
            this.trabajadorToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.trabajadorToolStripMenuItem.Text = "Trabajador";
            // 
            // ventaToolStripMenuItem1
            // 
            this.ventaToolStripMenuItem1.Name = "ventaToolStripMenuItem1";
            this.ventaToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.ventaToolStripMenuItem1.Text = "Venta";
            // 
            // dVentaToolStripMenuItem1
            // 
            this.dVentaToolStripMenuItem1.Name = "dVentaToolStripMenuItem1";
            this.dVentaToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dVentaToolStripMenuItem1.Text = "DVenta";
            // 
            // cmdRepoConsUMedida
            // 
            this.cmdRepoConsUMedida.Name = "cmdRepoConsUMedida";
            this.cmdRepoConsUMedida.Size = new System.Drawing.Size(131, 22);
            this.cmdRepoConsUMedida.Text = "UMedida";
            this.cmdRepoConsUMedida.Click += new System.EventHandler(this.cmdRepoConsUMedida_Click);
            // 
            // smnuRepoListar
            // 
            this.smnuRepoListar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdRepoListClientes,
            this.productosToolStripMenuItem,
            this.trabajadorToolStripMenuItem1,
            this.ventaToolStripMenuItem2,
            this.dVentaToolStripMenuItem2,
            this.cmdRepoListUMedida});
            this.smnuRepoListar.Name = "smnuRepoListar";
            this.smnuRepoListar.Size = new System.Drawing.Size(125, 22);
            this.smnuRepoListar.Text = "Listar";
            // 
            // cmdRepoListClientes
            // 
            this.cmdRepoListClientes.Name = "cmdRepoListClientes";
            this.cmdRepoListClientes.Size = new System.Drawing.Size(121, 23);
            this.cmdRepoListClientes.Text = "Clientes";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.productosToolStripMenuItem.Text = "Articulos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // trabajadorToolStripMenuItem1
            // 
            this.trabajadorToolStripMenuItem1.Name = "trabajadorToolStripMenuItem1";
            this.trabajadorToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.trabajadorToolStripMenuItem1.Text = "Trabajador";
            // 
            // ventaToolStripMenuItem2
            // 
            this.ventaToolStripMenuItem2.Name = "ventaToolStripMenuItem2";
            this.ventaToolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.ventaToolStripMenuItem2.Text = "Venta";
            // 
            // dVentaToolStripMenuItem2
            // 
            this.dVentaToolStripMenuItem2.Name = "dVentaToolStripMenuItem2";
            this.dVentaToolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.dVentaToolStripMenuItem2.Text = "DVenta";
            // 
            // cmdRepoListUMedida
            // 
            this.cmdRepoListUMedida.Name = "cmdRepoListUMedida";
            this.cmdRepoListUMedida.Size = new System.Drawing.Size(181, 22);
            this.cmdRepoListUMedida.Text = "UMedida";
            this.cmdRepoListUMedida.Click += new System.EventHandler(this.cmdRepoListUMedida_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(53, 20);
            this.mnuAyuda.Text = "Ayuda";
            // 
            // frmTcgMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tcgGUI.Properties.Resources.cubo_rubik;
            this.ClientSize = new System.Drawing.Size(378, 262);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTcgMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu TCG";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem cmdSistSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuEntidades;
        private System.Windows.Forms.ToolStripMenuItem smnuEntiCliente;
        private System.Windows.Forms.ToolStripMenuItem cmdEntiClieRegistrar;
        private System.Windows.Forms.ToolStripMenuItem cmdEntiClieActualizar;
        private System.Windows.Forms.ToolStripMenuItem cmdEntiClieEliminar;
        private System.Windows.Forms.ToolStripMenuItem smnuEntiProducto;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smnuEntiTrabajador;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuMovimientos;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem smnuRepoConsultar;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smnuRepoListar;
        private System.Windows.Forms.ToolStripComboBox cmdRepoListClientes;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem uMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdEntiUMedRegistrar;
        private System.Windows.Forms.ToolStripMenuItem cmdEntiUMedActualizar;
        private System.Windows.Forms.ToolStripMenuItem cmdEntiUMedEliminar;
        private System.Windows.Forms.ToolStripMenuItem trabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dVentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmdRepoConsUMedida;
        private System.Windows.Forms.ToolStripMenuItem trabajadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dVentaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmdRepoListUMedida;
    }
}

