namespace PryEdDiazB
{
    partial class frmDatosDesarrollador
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
            this.lblDev = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblIES = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(27, 84);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(236, 37);
            this.lblDev.TabIndex = 0;
            this.lblDev.Text = "Benjamin Diaz";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(29, 180);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(182, 29);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI: 44.648.587";
            // 
            // lblIES
            // 
            this.lblIES.AutoSize = true;
            this.lblIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIES.Location = new System.Drawing.Point(29, 271);
            this.lblIES.Name = "lblIES";
            this.lblIES.Size = new System.Drawing.Size(280, 25);
            this.lblIES.TabIndex = 2;
            this.lblIES.Text = "Colegio Universitario IES 21";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEdDiazB.Properties.Resources.IMG_2584;
            this.pictureBox1.Location = new System.Drawing.Point(348, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PryEdDiazB.Properties.Resources.pngtree_orange_and_white_abstract_line_wave_png_image_6749938;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIES);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblDev);
            this.Name = "frmDatosDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Desarrollador";
            this.Load += new System.EventHandler(this.frmDatosDesarrollador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblIES;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}