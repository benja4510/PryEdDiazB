namespace PryEdDiazB
{
    partial class frmBdRepaso
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
            this.lblOperacionaRealizar = new System.Windows.Forms.Label();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblVacio = new System.Windows.Forms.Label();
            this.dgvRepaso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepaso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacionaRealizar
            // 
            this.lblOperacionaRealizar.AutoSize = true;
            this.lblOperacionaRealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacionaRealizar.Location = new System.Drawing.Point(12, 35);
            this.lblOperacionaRealizar.Name = "lblOperacionaRealizar";
            this.lblOperacionaRealizar.Size = new System.Drawing.Size(241, 13);
            this.lblOperacionaRealizar.TabIndex = 0;
            this.lblOperacionaRealizar.Text = "Operacion a realizar en la base de datos:";
            // 
            // cboOperacion
            // 
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Location = new System.Drawing.Point(257, 32);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(315, 21);
            this.cboOperacion.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(587, 32);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblVacio
            // 
            this.lblVacio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVacio.Location = new System.Drawing.Point(27, 70);
            this.lblVacio.Name = "lblVacio";
            this.lblVacio.Size = new System.Drawing.Size(649, 103);
            this.lblVacio.TabIndex = 3;
            // 
            // dgvRepaso
            // 
            this.dgvRepaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepaso.Location = new System.Drawing.Point(27, 192);
            this.dgvRepaso.Name = "dgvRepaso";
            this.dgvRepaso.Size = new System.Drawing.Size(649, 231);
            this.dgvRepaso.TabIndex = 4;
            // 
            // frmBdRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.dgvRepaso);
            this.Controls.Add(this.lblVacio);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.lblOperacionaRealizar);
            this.Name = "frmBdRepaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepaso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacionaRealizar;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblVacio;
        private System.Windows.Forms.DataGridView dgvRepaso;
    }
}