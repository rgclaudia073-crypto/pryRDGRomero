namespace pryRDGRomero
{
    partial class frmEstructuraDeDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstSistema = new System.Windows.Forms.ToolStripSplitButton();
            this.datosDeDesarrolloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstProgramaOO = new System.Windows.Forms.ToolStripDropDownButton();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstSistema,
            this.tstProgramaOO});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tstSistema
            // 
            this.tstSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeDesarrolloToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.tstSistema.Name = "tstSistema";
            this.tstSistema.Size = new System.Drawing.Size(64, 22);
            this.tstSistema.Text = "Sistema";
            // 
            // datosDeDesarrolloToolStripMenuItem
            // 
            this.datosDeDesarrolloToolStripMenuItem.Name = "datosDeDesarrolloToolStripMenuItem";
            this.datosDeDesarrolloToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.datosDeDesarrolloToolStripMenuItem.Text = "Datos de desarrollo...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // tstProgramaOO
            // 
            this.tstProgramaOO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloresToolStripMenuItem,
            this.mesesToolStripMenuItem,
            this.carrerasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.alumnosToolStripMenuItem});
            this.tstProgramaOO.Name = "tstProgramaOO";
            this.tstProgramaOO.Size = new System.Drawing.Size(23, 22);
            this.tstProgramaOO.Text = ".";
            this.tstProgramaOO.Click += new System.EventHandler(this.tstProgramaOO_Click);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coloresToolStripMenuItem.Text = "Colores.";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // mesesToolStripMenuItem
            // 
            this.mesesToolStripMenuItem.Name = "mesesToolStripMenuItem";
            this.mesesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mesesToolStripMenuItem.Text = "Meses...";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes...";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos..";
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            // 
            // frmEstructuraDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEstructuraDeDatos";
            this.Text = "Estructura de Datos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tstSistema;
        private System.Windows.Forms.ToolStripMenuItem datosDeDesarrolloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tstProgramaOO;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
    }
}

