namespace MegaSystem
{
    partial class Menu_Principal
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarOModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarVentasDiariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSumaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarUnDatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarInformacionIngresadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUnaDatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUnDatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenAlRealizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarUnProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ventasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ordenesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.informacionToolStripMenuItem,
            this.eliminarOModificarToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem1.Text = "Empleado";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registrarToolStripMenuItem.Text = "Agregar Empleado";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.informacionToolStripMenuItem.Text = "Consultar informacion";
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // eliminarOModificarToolStripMenuItem
            // 
            this.eliminarOModificarToolStripMenuItem.Name = "eliminarOModificarToolStripMenuItem";
            this.eliminarOModificarToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarOModificarToolStripMenuItem.Text = "Eliminar o Editar";
            this.eliminarOModificarToolStripMenuItem.Click += new System.EventHandler(this.eliminarOModificarToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarVentasDiariasToolStripMenuItem,
            this.consultarSumaDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // mostrarVentasDiariasToolStripMenuItem
            // 
            this.mostrarVentasDiariasToolStripMenuItem.Name = "mostrarVentasDiariasToolStripMenuItem";
            this.mostrarVentasDiariasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mostrarVentasDiariasToolStripMenuItem.Text = "Mostrar ventas diarias";
            this.mostrarVentasDiariasToolStripMenuItem.Click += new System.EventHandler(this.mostrarVentasDiariasToolStripMenuItem_Click);
            // 
            // consultarSumaDeVentasToolStripMenuItem
            // 
            this.consultarSumaDeVentasToolStripMenuItem.Name = "consultarSumaDeVentasToolStripMenuItem";
            this.consultarSumaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.consultarSumaDeVentasToolStripMenuItem.Text = "Consultar suma de ventas";
            this.consultarSumaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.consultarSumaDeVentasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarUnDatoToolStripMenuItem,
            this.mostrarInformacionIngresadaToolStripMenuItem,
            this.eliminarUnaDatoToolStripMenuItem,
            this.modificarUnDatoToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // ingresarUnDatoToolStripMenuItem
            // 
            this.ingresarUnDatoToolStripMenuItem.Name = "ingresarUnDatoToolStripMenuItem";
            this.ingresarUnDatoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.ingresarUnDatoToolStripMenuItem.Text = "Registrar producto";
            this.ingresarUnDatoToolStripMenuItem.Click += new System.EventHandler(this.ingresarUnDatoToolStripMenuItem_Click);
            // 
            // mostrarInformacionIngresadaToolStripMenuItem
            // 
            this.mostrarInformacionIngresadaToolStripMenuItem.Name = "mostrarInformacionIngresadaToolStripMenuItem";
            this.mostrarInformacionIngresadaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.mostrarInformacionIngresadaToolStripMenuItem.Text = "Mostrar informacion ingresada";
            this.mostrarInformacionIngresadaToolStripMenuItem.Click += new System.EventHandler(this.mostrarInformacionIngresadaToolStripMenuItem_Click);
            // 
            // eliminarUnaDatoToolStripMenuItem
            // 
            this.eliminarUnaDatoToolStripMenuItem.Name = "eliminarUnaDatoToolStripMenuItem";
            this.eliminarUnaDatoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.eliminarUnaDatoToolStripMenuItem.Text = "Eliminar un dato";
            this.eliminarUnaDatoToolStripMenuItem.Click += new System.EventHandler(this.eliminarUnaDatoToolStripMenuItem_Click);
            // 
            // modificarUnDatoToolStripMenuItem
            // 
            this.modificarUnDatoToolStripMenuItem.Name = "modificarUnDatoToolStripMenuItem";
            this.modificarUnDatoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.modificarUnDatoToolStripMenuItem.Text = "Modificar un dato";
            this.modificarUnDatoToolStripMenuItem.Click += new System.EventHandler(this.modificarUnDatoToolStripMenuItem_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenAlRealizarToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // ordenAlRealizarToolStripMenuItem
            // 
            this.ordenAlRealizarToolStripMenuItem.Name = "ordenAlRealizarToolStripMenuItem";
            this.ordenAlRealizarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ordenAlRealizarToolStripMenuItem.Text = "Registrar orden";
            this.ordenAlRealizarToolStripMenuItem.Click += new System.EventHandler(this.ordenAlRealizarToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarUnProveedorToolStripMenuItem,
            this.modificarOEliminarToolStripMenuItem,
            this.consultarProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // insertarUnProveedorToolStripMenuItem
            // 
            this.insertarUnProveedorToolStripMenuItem.Name = "insertarUnProveedorToolStripMenuItem";
            this.insertarUnProveedorToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.insertarUnProveedorToolStripMenuItem.Text = "Insertar un proveedor";
            this.insertarUnProveedorToolStripMenuItem.Click += new System.EventHandler(this.insertarUnProveedorToolStripMenuItem_Click);
            // 
            // modificarOEliminarToolStripMenuItem
            // 
            this.modificarOEliminarToolStripMenuItem.Name = "modificarOEliminarToolStripMenuItem";
            this.modificarOEliminarToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.modificarOEliminarToolStripMenuItem.Text = "Modificar o eliminar proveedor";
            this.modificarOEliminarToolStripMenuItem.Click += new System.EventHandler(this.modificarOEliminarToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarProductoToolStripMenuItem,
            this.modificarOEliminarProductoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.menuToolStripMenuItem.Text = "Menu de comida";
            // 
            // insertarProductoToolStripMenuItem
            // 
            this.insertarProductoToolStripMenuItem.Name = "insertarProductoToolStripMenuItem";
            this.insertarProductoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.insertarProductoToolStripMenuItem.Text = "Insertar producto";
            this.insertarProductoToolStripMenuItem.Click += new System.EventHandler(this.insertarProductoToolStripMenuItem_Click);
            // 
            // modificarOEliminarProductoToolStripMenuItem
            // 
            this.modificarOEliminarProductoToolStripMenuItem.Name = "modificarOEliminarProductoToolStripMenuItem";
            this.modificarOEliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.modificarOEliminarProductoToolStripMenuItem.Text = "Modificar o eliminar producto";
            this.modificarOEliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarOEliminarProductoToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem1});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // consultarProveedoresToolStripMenuItem
            // 
            this.consultarProveedoresToolStripMenuItem.Name = "consultarProveedoresToolStripMenuItem";
            this.consultarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.consultarProveedoresToolStripMenuItem.Text = "Consultar proveedores";
            this.consultarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.consultarProveedoresToolStripMenuItem_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 579);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarOModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentasDiariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarSumaDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarUnDatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarInformacionIngresadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUnaDatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUnDatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenAlRealizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarUnProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProveedoresToolStripMenuItem;
    }
}