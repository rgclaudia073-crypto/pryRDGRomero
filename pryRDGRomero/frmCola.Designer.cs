namespace pryRDGRomero
{
    partial class frmCola
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
            this.grpEliminarElementos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpNuevosElementos = new System.Windows.Forms.GroupBox();
            this.txtTrámite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTrámite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.dgvCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.lbltramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEliminarElementos.SuspendLayout();
            this.grpNuevosElementos.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarElementos
            // 
            this.grpEliminarElementos.Controls.Add(this.lbltramiteE);
            this.grpEliminarElementos.Controls.Add(this.lblNombreE);
            this.grpEliminarElementos.Controls.Add(this.lblCodigoE);
            this.grpEliminarElementos.Controls.Add(this.btnEliminar);
            this.grpEliminarElementos.Controls.Add(this.label1);
            this.grpEliminarElementos.Controls.Add(this.label2);
            this.grpEliminarElementos.Controls.Add(this.label3);
            this.grpEliminarElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarElementos.Location = new System.Drawing.Point(509, 12);
            this.grpEliminarElementos.Name = "grpEliminarElementos";
            this.grpEliminarElementos.Size = new System.Drawing.Size(217, 214);
            this.grpEliminarElementos.TabIndex = 3;
            this.grpEliminarElementos.TabStop = false;
            this.grpEliminarElementos.Text = "Eliminar Elemento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(66, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 31);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código:";
            // 
            // grpNuevosElementos
            // 
            this.grpNuevosElementos.Controls.Add(this.txtTrámite);
            this.grpNuevosElementos.Controls.Add(this.txtNombre);
            this.grpNuevosElementos.Controls.Add(this.txtCódigo);
            this.grpNuevosElementos.Controls.Add(this.btnAgregar);
            this.grpNuevosElementos.Controls.Add(this.lblTrámite);
            this.grpNuevosElementos.Controls.Add(this.lblNombre);
            this.grpNuevosElementos.Controls.Add(this.lblCódigo);
            this.grpNuevosElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevosElementos.Location = new System.Drawing.Point(262, 12);
            this.grpNuevosElementos.Name = "grpNuevosElementos";
            this.grpNuevosElementos.Size = new System.Drawing.Size(232, 214);
            this.grpNuevosElementos.TabIndex = 2;
            this.grpNuevosElementos.TabStop = false;
            this.grpNuevosElementos.Text = "Nuevo Elemento";
            // 
            // txtTrámite
            // 
            this.txtTrámite.Location = new System.Drawing.Point(110, 121);
            this.txtTrámite.Name = "txtTrámite";
            this.txtTrámite.Size = new System.Drawing.Size(116, 26);
            this.txtTrámite.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(110, 30);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(116, 26);
            this.txtCódigo.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(66, 168);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 31);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTrámite
            // 
            this.lblTrámite.AutoSize = true;
            this.lblTrámite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrámite.Location = new System.Drawing.Point(16, 121);
            this.lblTrámite.Name = "lblTrámite";
            this.lblTrámite.Size = new System.Drawing.Size(66, 20);
            this.lblTrámite.TabIndex = 5;
            this.lblTrámite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(16, 30);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(63, 20);
            this.lblCódigo.TabIndex = 3;
            this.lblCódigo.Text = "Código:";
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.dgvCola);
            this.grpListado.Controls.Add(this.lstCola);
            this.grpListado.Location = new System.Drawing.Point(3, 242);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(734, 243);
            this.grpListado.TabIndex = 5;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCódigo,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(250, 18);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(471, 212);
            this.dgvCola.TabIndex = 4;
            // 
            // dgvCódigo
            // 
            this.dgvCódigo.HeaderText = "Código";
            this.dgvCódigo.Name = "dgvCódigo";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(11, 18);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(222, 212);
            this.lstCola.TabIndex = 3;
            // 
            // lbltramiteE
            // 
            this.lbltramiteE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltramiteE.Location = new System.Drawing.Point(101, 120);
            this.lbltramiteE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltramiteE.Name = "lbltramiteE";
            this.lbltramiteE.Size = new System.Drawing.Size(103, 24);
            this.lbltramiteE.TabIndex = 16;
            this.lbltramiteE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreE
            // 
            this.lblNombreE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreE.Location = new System.Drawing.Point(101, 69);
            this.lblNombreE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(102, 24);
            this.lblNombreE.TabIndex = 15;
            this.lblNombreE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoE.Location = new System.Drawing.Point(101, 24);
            this.lblCodigoE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(75, 26);
            this.lblCodigoE.TabIndex = 14;
            this.lblCodigoE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryRDGRomero.Properties.Resources.cola;
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpEliminarElementos);
            this.Controls.Add(this.grpNuevosElementos);
            this.Name = "frmCola";
            this.Text = "Estructura Dinamica de Datos-Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.grpEliminarElementos.ResumeLayout(false);
            this.grpEliminarElementos.PerformLayout();
            this.grpNuevosElementos.ResumeLayout(false);
            this.grpNuevosElementos.PerformLayout();
            this.grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEliminarElementos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpNuevosElementos;
        private System.Windows.Forms.TextBox txtTrámite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTrámite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Label lbltramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}