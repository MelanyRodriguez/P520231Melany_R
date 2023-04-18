namespace P520231Melany_R.Formulario
{
    partial class FrmRegistroCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroCompras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboxCompraTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnProovedorBuscar = new System.Windows.Forms.Button();
            this.TxtProovedorNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnProductoAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnProductoEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnProductoEliminar = new System.Windows.Forms.ToolStripButton();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCrearCompra = new System.Windows.Forms.Button();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVentaUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboxCompraTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnProovedorBuscar);
            this.groupBox1.Controls.Add(this.TxtProovedorNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado(Tabla Compra)";
            // 
            // CboxCompraTipo
            // 
            this.CboxCompraTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCompraTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxCompraTipo.FormattingEnabled = true;
            this.CboxCompraTipo.Location = new System.Drawing.Point(91, 65);
            this.CboxCompraTipo.Name = "CboxCompraTipo";
            this.CboxCompraTipo.Size = new System.Drawing.Size(375, 21);
            this.CboxCompraTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Compra";
            // 
            // BtnProovedorBuscar
            // 
            this.BtnProovedorBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProovedorBuscar.Location = new System.Drawing.Point(485, 27);
            this.BtnProovedorBuscar.Name = "BtnProovedorBuscar";
            this.BtnProovedorBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnProovedorBuscar.TabIndex = 2;
            this.BtnProovedorBuscar.Text = "Buscar...";
            this.BtnProovedorBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtProovedorNombre
            // 
            this.TxtProovedorNombre.Location = new System.Drawing.Point(83, 37);
            this.TxtProovedorNombre.Name = "TxtProovedorNombre";
            this.TxtProovedorNombre.Size = new System.Drawing.Size(383, 20);
            this.TxtProovedorNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proovedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvLista);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(31, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle(Tabla Compra Detalle)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notas:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(72, 97);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(394, 58);
            this.TxtNotas.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnProductoAgregar,
            this.BtnProductoEditar,
            this.BtnProductoEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnProductoAgregar
            // 
            this.BtnProductoAgregar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnProductoAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductoAgregar.Image")));
            this.BtnProductoAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoAgregar.Name = "BtnProductoAgregar";
            this.BtnProductoAgregar.Size = new System.Drawing.Size(121, 22);
            this.BtnProductoAgregar.Text = "Agregar Producto";
            // 
            // BtnProductoEditar
            // 
            this.BtnProductoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnProductoEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductoEditar.Image")));
            this.BtnProductoEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoEditar.Name = "BtnProductoEditar";
            this.BtnProductoEditar.Size = new System.Drawing.Size(130, 22);
            this.BtnProductoEditar.Text = "Modificar Producto";
            // 
            // BtnProductoEliminar
            // 
            this.BtnProductoEliminar.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnProductoEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductoEliminar.Image")));
            this.BtnProductoEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoEliminar.Name = "BtnProductoEliminar";
            this.BtnProductoEliminar.Size = new System.Drawing.Size(122, 22);
            this.BtnProductoEliminar.Text = "Eliminar Producto";
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProductoID,
            this.CPrecioVentaUnitario,
            this.CProductoCodigoBarras,
            this.CProductoNombre,
            this.CCantidad});
            this.DgvLista.Location = new System.Drawing.Point(21, 57);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(539, 150);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtTotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtTotalCantidad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(30, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TOTALES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "CANTIDAD ITEMS";
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtTotalCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCantidad.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalCantidad.Location = new System.Drawing.Point(1, 41);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.ReadOnly = true;
            this.TxtTotalCantidad.Size = new System.Drawing.Size(161, 25);
            this.TxtTotalCantidad.TabIndex = 1;
            this.TxtTotalCantidad.Text = "0";
            this.TxtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.DimGray;
            this.TxtTotal.Location = new System.Drawing.Point(299, 41);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(161, 25);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL";
            // 
            // BtnCrearCompra
            // 
            this.BtnCrearCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCrearCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCompra.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCrearCompra.Location = new System.Drawing.Point(228, 597);
            this.BtnCrearCompra.Name = "BtnCrearCompra";
            this.BtnCrearCompra.Size = new System.Drawing.Size(190, 33);
            this.BtnCrearCompra.TabIndex = 3;
            this.BtnCrearCompra.Text = "Crear Compra";
            this.BtnCrearCompra.UseVisualStyleBackColor = false;
            // 
            // CProductoID
            // 
            this.CProductoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProductoID.DataPropertyName = "ProductoID";
            this.CProductoID.HeaderText = "Codigo";
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.ReadOnly = true;
            // 
            // CPrecioVentaUnitario
            // 
            this.CPrecioVentaUnitario.DataPropertyName = "PrecioVentaUnitario";
            this.CPrecioVentaUnitario.HeaderText = "PrecioUnitario";
            this.CPrecioVentaUnitario.Name = "CPrecioVentaUnitario";
            this.CPrecioVentaUnitario.ReadOnly = true;
            // 
            // CProductoCodigoBarras
            // 
            this.CProductoCodigoBarras.DataPropertyName = "ProductoCodigoBarras";
            this.CProductoCodigoBarras.HeaderText = "Codigo Barras";
            this.CProductoCodigoBarras.Name = "CProductoCodigoBarras";
            this.CProductoCodigoBarras.ReadOnly = true;
            // 
            // CProductoNombre
            // 
            this.CProductoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProductoNombre.DataPropertyName = "ProductoNombre";
            this.CProductoNombre.HeaderText = "Producto";
            this.CProductoNombre.Name = "CProductoNombre";
            this.CProductoNombre.ReadOnly = true;
            // 
            // CCantidad
            // 
            this.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            // 
            // FrmRegistroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 685);
            this.Controls.Add(this.BtnCrearCompra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistroCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroDeCompras";
            this.Load += new System.EventHandler(this.FrmRegistroCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProovedorNombre;
        private System.Windows.Forms.ComboBox CboxCompraTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnProovedorBuscar;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnProductoAgregar;
        private System.Windows.Forms.ToolStripButton BtnProductoEditar;
        private System.Windows.Forms.ToolStripButton BtnProductoEliminar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCrearCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVentaUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
    }
}