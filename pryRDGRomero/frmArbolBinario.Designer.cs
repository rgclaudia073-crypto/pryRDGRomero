namespace pryRDGRomero
{
    partial class frmArbolBinario
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
            this.grpNuevoElemnto = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grpElementoEliminar = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.grpNuevoElemnto.SuspendLayout();
            this.grpElementoEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNuevoElemnto
            // 
            this.grpNuevoElemnto.Controls.Add(this.btnAgregar);
            this.grpNuevoElemnto.Controls.Add(this.textBox3);
            this.grpNuevoElemnto.Controls.Add(this.textBox2);
            this.grpNuevoElemnto.Controls.Add(this.textBox1);
            this.grpNuevoElemnto.Controls.Add(this.lblTramite);
            this.grpNuevoElemnto.Controls.Add(this.lblNombre);
            this.grpNuevoElemnto.Controls.Add(this.lblCodigo);
            this.grpNuevoElemnto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoElemnto.Location = new System.Drawing.Point(245, 29);
            this.grpNuevoElemnto.Name = "grpNuevoElemnto";
            this.grpNuevoElemnto.Size = new System.Drawing.Size(231, 213);
            this.grpNuevoElemnto.TabIndex = 0;
            this.grpNuevoElemnto.TabStop = false;
            this.grpNuevoElemnto.Text = "Nuevo Elemento";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(215, 213);
            this.treeView1.TabIndex = 1;
            // 
            // grpElementoEliminar
            // 
            this.grpElementoEliminar.Controls.Add(this.btnEquilibrar);
            this.grpElementoEliminar.Controls.Add(this.comboBox1);
            this.grpElementoEliminar.Controls.Add(this.lblCódigo);
            this.grpElementoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElementoEliminar.Location = new System.Drawing.Point(482, 29);
            this.grpElementoEliminar.Name = "grpElementoEliminar";
            this.grpElementoEliminar.Size = new System.Drawing.Size(220, 131);
            this.grpElementoEliminar.TabIndex = 2;
            this.grpElementoEliminar.TabStop = false;
            this.grpElementoEliminar.Text = "Elemento a Eliminar";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(7, 111);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(66, 20);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 26);
            this.textBox3.TabIndex = 5;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(6, 31);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(67, 20);
            this.lblCódigo.TabIndex = 1;
            this.lblCódigo.Text = "Código :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(58, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(59, 93);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(111, 32);
            this.btnEquilibrar.TabIndex = 3;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 480);
            this.Controls.Add(this.grpElementoEliminar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grpNuevoElemnto);
            this.Name = "frmArbolBinario";
            this.Text = "Estructuras Ramifadas - ArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.grpNuevoElemnto.ResumeLayout(false);
            this.grpNuevoElemnto.PerformLayout();
            this.grpElementoEliminar.ResumeLayout(false);
            this.grpElementoEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevoElemnto;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox grpElementoEliminar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEquilibrar;
    }
}