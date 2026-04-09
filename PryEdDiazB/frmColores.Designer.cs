namespace PryEdDiazB
{
    partial class frmColores
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
            this.lblColor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(59, 65);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(177, 116);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(110, 23);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Location = new System.Drawing.Point(62, 172);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(225, 121);
            this.lstColores.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(77, 116);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 398);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblColor);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.Load += new System.EventHandler(this.frmColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox lstColores;
        private System.Windows.Forms.Button btnLimpiar;
    }
}