
namespace lab02
{
    partial class PrincipalMDI
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
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSisSalir
            // 
            this.mnuSisSalir.Name = "mnuSisSalir";
            this.mnuSisSalir.Size = new System.Drawing.Size(158, 22);
            this.mnuSisSalir.Text = "Salir del sistema";
            this.mnuSisSalir.Click += new System.EventHandler(this.mnuSisSalir_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(139, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(139, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(139, 22);
            this.mnuManCategorias.Text = "Categorías";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(139, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(139, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcVentas,
            this.mnuProcCompras});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProcVentas
            // 
            this.mnuProcVentas.Name = "mnuProcVentas";
            this.mnuProcVentas.Size = new System.Drawing.Size(166, 22);
            this.mnuProcVentas.Text = "Registrar Venta";
            // 
            // mnuProcCompras
            // 
            this.mnuProcCompras.Name = "mnuProcCompras";
            this.mnuProcCompras.Size = new System.Drawing.Size(166, 22);
            this.mnuProcCompras.Text = "Registrar Compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepVentas,
            this.mnuRepCompras,
            this.mnuRepProductos,
            this.mnuRepProveedores,
            this.mnuRepUsuarios,
            this.mnuRepClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuRepVentas
            // 
            this.mnuRepVentas.Name = "mnuRepVentas";
            this.mnuRepVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuRepVentas.Text = "Reporte de ventas";
            // 
            // mnuRepCompras
            // 
            this.mnuRepCompras.Name = "mnuRepCompras";
            this.mnuRepCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuRepCompras.Text = "Reporte de compras";
            // 
            // mnuRepProductos
            // 
            this.mnuRepProductos.Name = "mnuRepProductos";
            this.mnuRepProductos.Size = new System.Drawing.Size(200, 22);
            this.mnuRepProductos.Text = "Inventario de productos";
            // 
            // mnuRepProveedores
            // 
            this.mnuRepProveedores.Name = "mnuRepProveedores";
            this.mnuRepProveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuRepProveedores.Text = "Reporte de proveedores";
            // 
            // mnuRepUsuarios
            // 
            this.mnuRepUsuarios.Name = "mnuRepUsuarios";
            this.mnuRepUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuRepUsuarios.Text = "Reporte de usuarios";
            // 
            // mnuRepClientes
            // 
            this.mnuRepClientes.Name = "mnuRepClientes";
            this.mnuRepClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuRepClientes.Text = "Reporte de clientes";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.Text = "Panel principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalir;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProcVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuProcCompras;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRepVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepClientes;
    }
}