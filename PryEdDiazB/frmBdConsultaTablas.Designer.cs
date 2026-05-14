namespace PryEdDiazB
{
    partial class frmBdConsultaTablas
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
            this.lblTabla = new System.Windows.Forms.Label();
            this.cboTablaDatos = new System.Windows.Forms.ComboBox();
            this.dgvTablaDatos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(270, 415);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(206, 18);
            this.lblTabla.TabIndex = 0;
            this.lblTabla.Text = "Tabla de la base de datos:";
            // 
            // cboTablaDatos
            // 
            this.cboTablaDatos.FormattingEnabled = true;
            this.cboTablaDatos.Location = new System.Drawing.Point(482, 412);
            this.cboTablaDatos.Name = "cboTablaDatos";
            this.cboTablaDatos.Size = new System.Drawing.Size(121, 21);
            this.cboTablaDatos.TabIndex = 1;
            // 
            // dgvTablaDatos
            // 
            this.dgvTablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvTablaDatos.Name = "dgvTablaDatos";
            this.dgvTablaDatos.Size = new System.Drawing.Size(695, 381);
            this.dgvTablaDatos.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(618, 412);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmBdConsultaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvTablaDatos);
            this.Controls.Add(this.cboTablaDatos);
            this.Controls.Add(this.lblTabla);
            this.Name = "frmBdConsultaTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de una tabla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox cboTablaDatos;
        private System.Windows.Forms.DataGridView dgvTablaDatos;
        private System.Windows.Forms.Button btnListar;
    }
}