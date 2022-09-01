namespace Lab02_01
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
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegisventa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegiscompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReventas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepInventarioproductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReproveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalirsistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cToolStripMenuItem.Text = "Mantenimiento";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuManCategorias.Text = "Categorías";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRegisventa,
            this.mnuProRegiscompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProRegisventa
            // 
            this.mnuProRegisventa.Name = "mnuProRegisventa";
            this.mnuProRegisventa.Size = new System.Drawing.Size(166, 22);
            this.mnuProRegisventa.Text = "Registrar Venta";
            // 
            // mnuProRegiscompra
            // 
            this.mnuProRegiscompra.Name = "mnuProRegiscompra";
            this.mnuProRegiscompra.Size = new System.Drawing.Size(166, 22);
            this.mnuProRegiscompra.Text = "Registrar Compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepReventas,
            this.mnuRepReCompras,
            this.mnuRepInventarioproductos,
            this.mnuRepReproveedores,
            this.mnuRepReusuarios,
            this.mnuRepReclientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuRepReventas
            // 
            this.mnuRepReventas.Name = "mnuRepReventas";
            this.mnuRepReventas.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReventas.Text = "Reporte de ventas";
            // 
            // mnuRepReCompras
            // 
            this.mnuRepReCompras.Name = "mnuRepReCompras";
            this.mnuRepReCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReCompras.Text = "Reporte de compras";
            // 
            // mnuRepInventarioproductos
            // 
            this.mnuRepInventarioproductos.Name = "mnuRepInventarioproductos";
            this.mnuRepInventarioproductos.Size = new System.Drawing.Size(200, 22);
            this.mnuRepInventarioproductos.Text = "Inventario de productos";
            // 
            // mnuRepReproveedores
            // 
            this.mnuRepReproveedores.Name = "mnuRepReproveedores";
            this.mnuRepReproveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReproveedores.Text = "Reporte de proveedores";
            // 
            // mnuRepReusuarios
            // 
            this.mnuRepReusuarios.Name = "mnuRepReusuarios";
            this.mnuRepReusuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReusuarios.Text = "Reporte de usuarios";
            // 
            // mnuRepReclientes
            // 
            this.mnuRepReclientes.Name = "mnuRepReclientes";
            this.mnuRepReclientes.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReclientes.Text = "Reporte de clientes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalirsistema});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSisSalirsistema
            // 
            this.mnuSisSalirsistema.Name = "mnuSisSalirsistema";
            this.mnuSisSalirsistema.Size = new System.Drawing.Size(180, 22);
            this.mnuSisSalirsistema.Text = "Salir del sistema";
            this.mnuSisSalirsistema.Click += new System.EventHandler(this.mnuSisSalirsistema_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegisventa;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegiscompra;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReventas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepInventarioproductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReproveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReusuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReclientes;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalirsistema;
    }
}