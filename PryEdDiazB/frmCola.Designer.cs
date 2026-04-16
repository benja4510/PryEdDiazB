namespace PryEdDiazB
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
            this.gboNuevoElemento = new System.Windows.Forms.GroupBox();
            this.gboElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.gboListado = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboNuevoElemento.SuspendLayout();
            this.gboElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.gboListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboNuevoElemento
            // 
            this.gboNuevoElemento.Controls.Add(this.btnAgregar);
            this.gboNuevoElemento.Controls.Add(this.txtTramite);
            this.gboNuevoElemento.Controls.Add(this.txtNombre);
            this.gboNuevoElemento.Controls.Add(this.txtCodigo);
            this.gboNuevoElemento.Controls.Add(this.label1);
            this.gboNuevoElemento.Controls.Add(this.lblNombre);
            this.gboNuevoElemento.Controls.Add(this.lblCodigo);
            this.gboNuevoElemento.Location = new System.Drawing.Point(191, 39);
            this.gboNuevoElemento.Name = "gboNuevoElemento";
            this.gboNuevoElemento.Size = new System.Drawing.Size(209, 218);
            this.gboNuevoElemento.TabIndex = 0;
            this.gboNuevoElemento.TabStop = false;
            this.gboNuevoElemento.Text = "Nuevo Elemento";
            // 
            // gboElementoEliminado
            // 
            this.gboElementoEliminado.Controls.Add(this.btnEliminar);
            this.gboElementoEliminado.Controls.Add(this.label4);
            this.gboElementoEliminado.Controls.Add(this.label3);
            this.gboElementoEliminado.Controls.Add(this.label2);
            this.gboElementoEliminado.Controls.Add(this.lblTramite2);
            this.gboElementoEliminado.Controls.Add(this.lblNombre2);
            this.gboElementoEliminado.Controls.Add(this.lblCodigo2);
            this.gboElementoEliminado.Location = new System.Drawing.Point(425, 39);
            this.gboElementoEliminado.Name = "gboElementoEliminado";
            this.gboElementoEliminado.Size = new System.Drawing.Size(200, 218);
            this.gboElementoEliminado.TabIndex = 0;
            this.gboElementoEliminado.TabStop = false;
            this.gboElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tramite:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(92, 108);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(21, 36);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2.TabIndex = 1;
            this.lblCodigo2.Text = "Codigo:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(21, 71);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 2;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(21, 111);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(45, 13);
            this.lblTramite2.TabIndex = 3;
            this.lblTramite2.Text = "Tramite:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(94, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(94, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(94, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(174, 41);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(24, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 41);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(197, 32);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(434, 225);
            this.dgvCola.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(18, 32);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(173, 212);
            this.lstCola.TabIndex = 2;
            // 
            // gboListado
            // 
            this.gboListado.Controls.Add(this.dgvCola);
            this.gboListado.Controls.Add(this.lstCola);
            this.gboListado.Location = new System.Drawing.Point(12, 317);
            this.gboListado.Name = "gboListado";
            this.gboListado.Size = new System.Drawing.Size(644, 263);
            this.gboListado.TabIndex = 3;
            this.gboListado.TabStop = false;
            this.gboListado.Text = "Listado en una Lista y una Grilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEdDiazB.Properties.Resources.b10;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboListado);
            this.Controls.Add(this.gboElementoEliminado);
            this.Controls.Add(this.gboNuevoElemento);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Lineal- Cola";
            this.gboNuevoElemento.ResumeLayout(false);
            this.gboNuevoElemento.PerformLayout();
            this.gboElementoEliminado.ResumeLayout(false);
            this.gboElementoEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.gboListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboNuevoElemento;
        private System.Windows.Forms.GroupBox gboElementoEliminado;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.GroupBox gboListado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}