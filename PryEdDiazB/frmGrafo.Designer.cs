namespace PryEdDiazB
{
    partial class frmGrafo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.gboConsulta = new System.Windows.Forms.GroupBox();
            this.lblPrecio3 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cboDestino2 = new System.Windows.Forms.ComboBox();
            this.cboOrigen2 = new System.Windows.Forms.ComboBox();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.gboListar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.cboHasta = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cboDesde = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gboConsulta.SuspendLayout();
            this.gboListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.btnBorrarTodo);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.cboDestino);
            this.groupBox1.Controls.Add(this.cboOrigen);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.lblOrigen);
            this.groupBox1.Location = new System.Drawing.Point(197, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga De Datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(169, 151);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(49, 151);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(88, 103);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(181, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(88, 71);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(185, 21);
            this.cboDestino.TabIndex = 4;
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(88, 38);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(185, 21);
            this.cboOrigen.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(37, 106);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(36, 74);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(36, 46);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // gboConsulta
            // 
            this.gboConsulta.Controls.Add(this.lblPrecio3);
            this.gboConsulta.Controls.Add(this.btnConsultar);
            this.gboConsulta.Controls.Add(this.btnBorrar);
            this.gboConsulta.Controls.Add(this.cboDestino2);
            this.gboConsulta.Controls.Add(this.cboOrigen2);
            this.gboConsulta.Controls.Add(this.lblPrecio2);
            this.gboConsulta.Controls.Add(this.lblDestino2);
            this.gboConsulta.Controls.Add(this.lblOrigen2);
            this.gboConsulta.Location = new System.Drawing.Point(507, 12);
            this.gboConsulta.Name = "gboConsulta";
            this.gboConsulta.Size = new System.Drawing.Size(281, 196);
            this.gboConsulta.TabIndex = 1;
            this.gboConsulta.TabStop = false;
            this.gboConsulta.Text = "Consulta De Datos";
            // 
            // lblPrecio3
            // 
            this.lblPrecio3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecio3.Location = new System.Drawing.Point(91, 105);
            this.lblPrecio3.Name = "lblPrecio3";
            this.lblPrecio3.Size = new System.Drawing.Size(182, 23);
            this.lblPrecio3.TabIndex = 8;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(52, 151);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(176, 151);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // cboDestino2
            // 
            this.cboDestino2.FormattingEnabled = true;
            this.cboDestino2.Location = new System.Drawing.Point(88, 71);
            this.cboDestino2.Name = "cboDestino2";
            this.cboDestino2.Size = new System.Drawing.Size(185, 21);
            this.cboDestino2.TabIndex = 4;
            // 
            // cboOrigen2
            // 
            this.cboOrigen2.FormattingEnabled = true;
            this.cboOrigen2.Location = new System.Drawing.Point(88, 38);
            this.cboOrigen2.Name = "cboOrigen2";
            this.cboOrigen2.Size = new System.Drawing.Size(185, 21);
            this.cboOrigen2.TabIndex = 3;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(37, 106);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio2.TabIndex = 2;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(36, 74);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(46, 13);
            this.lblDestino2.TabIndex = 1;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(36, 46);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen2.TabIndex = 0;
            this.lblOrigen2.Text = "Origen:";
            // 
            // gboListar
            // 
            this.gboListar.Controls.Add(this.dataGridView1);
            this.gboListar.Controls.Add(this.btnVerViajes);
            this.gboListar.Controls.Add(this.btnListarOrigenes);
            this.gboListar.Controls.Add(this.cboHasta);
            this.gboListar.Controls.Add(this.lblHasta);
            this.gboListar.Controls.Add(this.btnListarDestinos);
            this.gboListar.Controls.Add(this.cboDesde);
            this.gboListar.Controls.Add(this.lblDesde);
            this.gboListar.Location = new System.Drawing.Point(22, 228);
            this.gboListar.Name = "gboListar";
            this.gboListar.Size = new System.Drawing.Size(766, 272);
            this.gboListar.TabIndex = 2;
            this.gboListar.TabStop = false;
            this.gboListar.Text = "Listar Viajes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(21, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 181);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Origen";
            this.Column1.Name = "Column1";
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(648, 27);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(110, 23);
            this.btnVerViajes.TabIndex = 9;
            this.btnVerViajes.Text = "Ver todos los viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(524, 27);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(109, 23);
            this.btnListarOrigenes.TabIndex = 8;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // cboHasta
            // 
            this.cboHasta.FormattingEnabled = true;
            this.cboHasta.Location = new System.Drawing.Point(385, 29);
            this.cboHasta.Name = "cboHasta";
            this.cboHasta.Size = new System.Drawing.Size(121, 21);
            this.cboHasta.TabIndex = 7;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(341, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(203, 29);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(122, 23);
            this.btnListarDestinos.TabIndex = 5;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cboDesde
            // 
            this.cboDesde.FormattingEnabled = true;
            this.cboDesde.Location = new System.Drawing.Point(65, 31);
            this.cboDesde.Name = "cboDesde";
            this.cboDesde.Size = new System.Drawing.Size(121, 21);
            this.cboDesde.TabIndex = 4;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(18, 34);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cordoba";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mendoza";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Santa Fe";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Buenos Aires";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salta";
            this.Column6.Name = "Column6";
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboListar);
            this.Controls.Add(this.gboConsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones en un Grafo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboConsulta.ResumeLayout(false);
            this.gboConsulta.PerformLayout();
            this.gboListar.ResumeLayout(false);
            this.gboListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.GroupBox gboConsulta;
        private System.Windows.Forms.Label lblPrecio3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cboDestino2;
        private System.Windows.Forms.ComboBox cboOrigen2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.GroupBox gboListar;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.ComboBox cboHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cboDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}