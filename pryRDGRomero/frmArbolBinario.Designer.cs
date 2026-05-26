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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.grpElementoEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbCódigo = new System.Windows.Forms.ComboBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.btnEqulibrar = new System.Windows.Forms.Button();
            this.grpListadoArbol = new System.Windows.Forms.GroupBox();
            this.dgvLDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdPostOrden = new System.Windows.Forms.RadioButton();
            this.rdPreOrden = new System.Windows.Forms.RadioButton();
            this.rdInOrden = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpNuevoElemnto.SuspendLayout();
            this.grpElementoEliminar.SuspendLayout();
            this.grpListadoArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNuevoElemnto
            // 
            this.grpNuevoElemnto.Controls.Add(this.btnAgregar);
            this.grpNuevoElemnto.Controls.Add(this.txtTramite);
            this.grpNuevoElemnto.Controls.Add(this.txtNombre);
            this.grpNuevoElemnto.Controls.Add(this.txtCódigo);
            this.grpNuevoElemnto.Controls.Add(this.lblTramite);
            this.grpNuevoElemnto.Controls.Add(this.lblNombre);
            this.grpNuevoElemnto.Controls.Add(this.lblCodigo);
            this.grpNuevoElemnto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoElemnto.Location = new System.Drawing.Point(231, 18);
            this.grpNuevoElemnto.Name = "grpNuevoElemnto";
            this.grpNuevoElemnto.Size = new System.Drawing.Size(231, 217);
            this.grpNuevoElemnto.TabIndex = 0;
            this.grpNuevoElemnto.TabStop = false;
            this.grpNuevoElemnto.Text = "Nuevo Elemento";
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
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(92, 105);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(133, 26);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(168, 31);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(57, 26);
            this.txtCódigo.TabIndex = 3;
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
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(717, 25);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(407, 558);
            this.trvArbol.TabIndex = 1;
            // 
            // grpElementoEliminar
            // 
            this.grpElementoEliminar.Controls.Add(this.btnEliminar);
            this.grpElementoEliminar.Controls.Add(this.cmbCódigo);
            this.grpElementoEliminar.Controls.Add(this.lblCódigo);
            this.grpElementoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpElementoEliminar.Location = new System.Drawing.Point(482, 18);
            this.grpElementoEliminar.Name = "grpElementoEliminar";
            this.grpElementoEliminar.Size = new System.Drawing.Size(229, 142);
            this.grpElementoEliminar.TabIndex = 2;
            this.grpElementoEliminar.TabStop = false;
            this.grpElementoEliminar.Text = "Elemento a Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(59, 93);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cmbCódigo
            // 
            this.cmbCódigo.FormattingEnabled = true;
            this.cmbCódigo.Location = new System.Drawing.Point(79, 25);
            this.cmbCódigo.Name = "cmbCódigo";
            this.cmbCódigo.Size = new System.Drawing.Size(121, 28);
            this.cmbCódigo.TabIndex = 2;
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
            // btnEqulibrar
            // 
            this.btnEqulibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqulibrar.Location = new System.Drawing.Point(506, 191);
            this.btnEqulibrar.Name = "btnEqulibrar";
            this.btnEqulibrar.Size = new System.Drawing.Size(174, 44);
            this.btnEqulibrar.TabIndex = 3;
            this.btnEqulibrar.Text = "Equilibrar";
            this.btnEqulibrar.UseVisualStyleBackColor = true;
            // 
            // grpListadoArbol
            // 
            this.grpListadoArbol.Controls.Add(this.dgvLDatos);
            this.grpListadoArbol.Controls.Add(this.rdPostOrden);
            this.grpListadoArbol.Controls.Add(this.rdPreOrden);
            this.grpListadoArbol.Controls.Add(this.rdInOrden);
            this.grpListadoArbol.Location = new System.Drawing.Point(13, 258);
            this.grpListadoArbol.Name = "grpListadoArbol";
            this.grpListadoArbol.Size = new System.Drawing.Size(698, 325);
            this.grpListadoArbol.TabIndex = 4;
            this.grpListadoArbol.TabStop = false;
            this.grpListadoArbol.Text = "Listado del árbol";
            // 
            // dgvLDatos
            // 
            this.dgvLDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nombre,
            this.Column2});
            this.dgvLDatos.Location = new System.Drawing.Point(17, 82);
            this.dgvLDatos.Name = "dgvLDatos";
            this.dgvLDatos.Size = new System.Drawing.Size(652, 226);
            this.dgvLDatos.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Trámite";
            this.Column2.Name = "Column2";
            // 
            // rdPostOrden
            // 
            this.rdPostOrden.AutoSize = true;
            this.rdPostOrden.Location = new System.Drawing.Point(342, 35);
            this.rdPostOrden.Name = "rdPostOrden";
            this.rdPostOrden.Size = new System.Drawing.Size(78, 17);
            this.rdPostOrden.TabIndex = 2;
            this.rdPostOrden.TabStop = true;
            this.rdPostOrden.Text = "Post-Orden";
            this.rdPostOrden.UseVisualStyleBackColor = true;
            // 
            // rdPreOrden
            // 
            this.rdPreOrden.AutoSize = true;
            this.rdPreOrden.Location = new System.Drawing.Point(164, 35);
            this.rdPreOrden.Name = "rdPreOrden";
            this.rdPreOrden.Size = new System.Drawing.Size(73, 17);
            this.rdPreOrden.TabIndex = 1;
            this.rdPreOrden.TabStop = true;
            this.rdPreOrden.Text = "Pre-Orden";
            this.rdPreOrden.UseVisualStyleBackColor = true;
            // 
            // rdInOrden
            // 
            this.rdInOrden.AutoSize = true;
            this.rdInOrden.Location = new System.Drawing.Point(28, 35);
            this.rdInOrden.Name = "rdInOrden";
            this.rdInOrden.Size = new System.Drawing.Size(66, 17);
            this.rdInOrden.TabIndex = 0;
            this.rdInOrden.TabStop = true;
            this.rdInOrden.Text = "In-Orden";
            this.rdInOrden.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 210);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpListadoArbol);
            this.Controls.Add(this.btnEqulibrar);
            this.Controls.Add(this.grpElementoEliminar);
            this.Controls.Add(this.trvArbol);
            this.Controls.Add(this.grpNuevoElemnto);
            this.Name = "frmArbolBinario";
            this.Text = "Estructuras Ramifadas - ArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.grpNuevoElemnto.ResumeLayout(false);
            this.grpNuevoElemnto.PerformLayout();
            this.grpElementoEliminar.ResumeLayout(false);
            this.grpElementoEliminar.PerformLayout();
            this.grpListadoArbol.ResumeLayout(false);
            this.grpListadoArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevoElemnto;
        private System.Windows.Forms.TreeView trvArbol;
        private System.Windows.Forms.GroupBox grpElementoEliminar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCódigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEqulibrar;
        private System.Windows.Forms.GroupBox grpListadoArbol;
        private System.Windows.Forms.RadioButton rdPostOrden;
        private System.Windows.Forms.RadioButton rdPreOrden;
        private System.Windows.Forms.RadioButton rdInOrden;
        private System.Windows.Forms.DataGridView dgvLDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}