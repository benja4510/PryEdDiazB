namespace PryEdDiazB
{
    partial class frmDias
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
            this.lblDia = new System.Windows.Forms.Label();
            this.dtpDias = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lstDias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(104, 107);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(42, 24);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia:";
            // 
            // dtpDias
            // 
            this.dtpDias.Location = new System.Drawing.Point(184, 109);
            this.dtpDias.Name = "dtpDias";
            this.dtpDias.Size = new System.Drawing.Size(140, 20);
            this.dtpDias.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(108, 177);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 42);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(222, 177);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(86, 42);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lstDias
            // 
            this.lstDias.FormattingEnabled = true;
            this.lstDias.Location = new System.Drawing.Point(108, 265);
            this.lstDias.Name = "lstDias";
            this.lstDias.Size = new System.Drawing.Size(210, 134);
            this.lstDias.TabIndex = 4;
            // 
            // frmDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryEdDiazB.Properties.Resources.pngtree_orange_and_white_abstract_line_wave_png_image_6749938;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.lstDias);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpDias);
            this.Controls.Add(this.lblDia);
            this.Name = "frmDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dias";
            this.Load += new System.EventHandler(this.frmDias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.DateTimePicker dtpDias;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox lstDias;
    }
}