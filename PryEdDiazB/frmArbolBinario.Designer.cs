namespace PryEdDiazB
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Arbol");
            this.gboNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gboElementosEliminar = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboListadoArbol = new System.Windows.Forms.GroupBox();
            this.rdoPOST = new System.Windows.Forms.RadioButton();
            this.rdoPRE = new System.Windows.Forms.RadioButton();
            this.rdoIN = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gboNuevoElemento.SuspendLayout();
            this.gboElementosEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.gboListadoArbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboNuevoElemento
            // 
            this.gboNuevoElemento.Controls.Add(this.txtTramite);
            this.gboNuevoElemento.Controls.Add(this.btnAgregar);
            this.gboNuevoElemento.Controls.Add(this.txtNombre);
            this.gboNuevoElemento.Controls.Add(this.txtCodigo);
            this.gboNuevoElemento.Controls.Add(this.lblTramite);
            this.gboNuevoElemento.Controls.Add(this.lblNombre);
            this.gboNuevoElemento.Controls.Add(this.lblCodigo);
            this.gboNuevoElemento.Location = new System.Drawing.Point(297, 31);
            this.gboNuevoElemento.Name = "gboNuevoElemento";
            this.gboNuevoElemento.Size = new System.Drawing.Size(190, 218);
            this.gboNuevoElemento.TabIndex = 2;
            this.gboNuevoElemento.TabStop = false;
            this.gboNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(73, 105);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(174, 41);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(73, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(22, 108);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 3;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // gboElementosEliminar
            // 
            this.gboElementosEliminar.Controls.Add(this.btnEliminar);
            this.gboElementosEliminar.Controls.Add(this.cmbCodigo);
            this.gboElementosEliminar.Controls.Add(this.btnEquilibrar);
            this.gboElementosEliminar.Controls.Add(this.lblCodigo2);
            this.gboElementosEliminar.Location = new System.Drawing.Point(531, 31);
            this.gboElementosEliminar.Name = "gboElementosEliminar";
            this.gboElementosEliminar.Size = new System.Drawing.Size(200, 218);
            this.gboElementosEliminar.TabIndex = 7;
            this.gboElementosEliminar.TabStop = false;
            this.gboElementosEliminar.Text = "Elemento a Eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(70, 57);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(115, 21);
            this.cmbCodigo.TabIndex = 7;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(33, 161);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(141, 41);
            this.btnEquilibrar.TabIndex = 9;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(21, 60);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2.TabIndex = 2;
            this.lblCodigo2.Text = "Codigo:";
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvArbol.Location = new System.Drawing.Point(297, 277);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.Size = new System.Drawing.Size(434, 225);
            this.dgvArbol.TabIndex = 8;
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
            // gboListadoArbol
            // 
            this.gboListadoArbol.Controls.Add(this.rdoPOST);
            this.gboListadoArbol.Controls.Add(this.rdoPRE);
            this.gboListadoArbol.Controls.Add(this.rdoIN);
            this.gboListadoArbol.Location = new System.Drawing.Point(24, 277);
            this.gboListadoArbol.Name = "gboListadoArbol";
            this.gboListadoArbol.Size = new System.Drawing.Size(256, 225);
            this.gboListadoArbol.TabIndex = 9;
            this.gboListadoArbol.TabStop = false;
            this.gboListadoArbol.Text = "Listado del Arbol";
            // 
            // rdoPOST
            // 
            this.rdoPOST.AutoSize = true;
            this.rdoPOST.Location = new System.Drawing.Point(62, 158);
            this.rdoPOST.Name = "rdoPOST";
            this.rdoPOST.Size = new System.Drawing.Size(78, 17);
            this.rdoPOST.TabIndex = 2;
            this.rdoPOST.TabStop = true;
            this.rdoPOST.Text = "Post-Orden";
            this.rdoPOST.UseVisualStyleBackColor = true;
            this.rdoPOST.CheckedChanged += new System.EventHandler(this.rdoPOST_CheckedChanged);
            // 
            // rdoPRE
            // 
            this.rdoPRE.AutoSize = true;
            this.rdoPRE.Location = new System.Drawing.Point(62, 104);
            this.rdoPRE.Name = "rdoPRE";
            this.rdoPRE.Size = new System.Drawing.Size(73, 17);
            this.rdoPRE.TabIndex = 1;
            this.rdoPRE.TabStop = true;
            this.rdoPRE.Text = "Pre-Orden";
            this.rdoPRE.UseVisualStyleBackColor = true;
            this.rdoPRE.CheckedChanged += new System.EventHandler(this.rdoPRE_CheckedChanged);
            // 
            // rdoIN
            // 
            this.rdoIN.AutoSize = true;
            this.rdoIN.Location = new System.Drawing.Point(62, 49);
            this.rdoIN.Name = "rdoIN";
            this.rdoIN.Size = new System.Drawing.Size(66, 17);
            this.rdoIN.TabIndex = 0;
            this.rdoIN.TabStop = true;
            this.rdoIN.Text = "In-Orden";
            this.rdoIN.UseVisualStyleBackColor = true;
            this.rdoIN.CheckedChanged += new System.EventHandler(this.rdoIN_CheckedChanged);
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(24, 31);
            this.tvArbol.Name = "tvArbol";
            treeNode1.Name = "Arbol";
            treeNode1.Text = "Arbol";
            this.tvArbol.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvArbol.Size = new System.Drawing.Size(249, 218);
            this.tvArbol.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(60, 102);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 38);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 514);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.gboListadoArbol);
            this.Controls.Add(this.dgvArbol);
            this.Controls.Add(this.gboElementosEliminar);
            this.Controls.Add(this.gboNuevoElemento);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas- Arbol Binario";
            this.gboNuevoElemento.ResumeLayout(false);
            this.gboNuevoElemento.PerformLayout();
            this.gboElementosEliminar.ResumeLayout(false);
            this.gboElementosEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.gboListadoArbol.ResumeLayout(false);
            this.gboListadoArbol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gboElementosEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox gboListadoArbol;
        private System.Windows.Forms.RadioButton rdoPOST;
        private System.Windows.Forms.RadioButton rdoPRE;
        private System.Windows.Forms.RadioButton rdoIN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnEliminar;
    }
}