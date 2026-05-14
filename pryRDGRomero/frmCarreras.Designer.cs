namespace pryRDGRomero
{
    partial class frmCarreras
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtCarreras = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lstCarrera = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(45, 39);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(77, 24);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Carrera:";
            // 
            // txtCarreras
            // 
            this.txtCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarreras.Location = new System.Drawing.Point(139, 39);
            this.txtCarreras.Name = "txtCarreras";
            this.txtCarreras.Size = new System.Drawing.Size(170, 26);
            this.txtCarreras.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(181, 117);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(87, 28);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lstCarrera
            // 
            this.lstCarrera.FormattingEnabled = true;
            this.lstCarrera.Location = new System.Drawing.Point(12, 165);
            this.lstCarrera.Name = "lstCarrera";
            this.lstCarrera.Size = new System.Drawing.Size(311, 160);
            this.lstCarrera.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(49, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 28);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 390);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstCarrera);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtCarreras);
            this.Controls.Add(this.lblCarrera);
            this.Name = "frmCarreras";
            this.Text = "frmCarreras";
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtCarreras;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox lstCarrera;
        private System.Windows.Forms.Button btnLimpiar;
    }
}