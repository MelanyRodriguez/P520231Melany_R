namespace P520231Melany_R.Formulario
{
    partial class FrmGestionProovedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CboxVerProovedoresActivos = new System.Windows.Forms.CheckBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtProveedorID = new System.Windows.Forms.TextBox();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.TxtProveedorCedula = new System.Windows.Forms.TextBox();
            this.TxtProveedorEmail = new System.Windows.Forms.TextBox();
            this.TxtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.CbTipoProovedor = new System.Windows.Forms.ComboBox();
            this.TxtProveedorNotas = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(139, 32);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(450, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CboxVerProovedoresActivos
            // 
            this.CboxVerProovedoresActivos.AutoSize = true;
            this.CboxVerProovedoresActivos.Checked = true;
            this.CboxVerProovedoresActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerProovedoresActivos.Location = new System.Drawing.Point(636, 42);
            this.CboxVerProovedoresActivos.Name = "CboxVerProovedoresActivos";
            this.CboxVerProovedoresActivos.Size = new System.Drawing.Size(149, 17);
            this.CboxVerProovedoresActivos.TabIndex = 2;
            this.CboxVerProovedoresActivos.Text = "Ver Proovedores Actuales";
            this.CboxVerProovedoresActivos.UseVisualStyleBackColor = true;
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProveedorID,
            this.CProveedorNombre,
            this.CProveedorCedula,
            this.CProveedorEmail,
            this.CProveedorDireccion,
            this.CProveedorNotas});
            this.DgLista.Location = new System.Drawing.Point(51, 92);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.Size = new System.Drawing.Size(717, 179);
            this.DgLista.TabIndex = 3;
            this.DgLista.VirtualMode = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtProveedorNotas);
            this.groupBox1.Controls.Add(this.CbTipoProovedor);
            this.groupBox1.Controls.Add(this.TxtProveedorDireccion);
            this.groupBox1.Controls.Add(this.TxtProveedorEmail);
            this.groupBox1.Controls.Add(this.TxtProveedorCedula);
            this.groupBox1.Controls.Add(this.TxtProveedorNombre);
            this.groupBox1.Controls.Add(this.TxtProveedorID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 233);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Proovedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Notas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo Proveedor:";
            // 
            // TxtProveedorID
            // 
            this.TxtProveedorID.Location = new System.Drawing.Point(71, 36);
            this.TxtProveedorID.Name = "TxtProveedorID";
            this.TxtProveedorID.ReadOnly = true;
            this.TxtProveedorID.Size = new System.Drawing.Size(191, 20);
            this.TxtProveedorID.TabIndex = 7;
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.Location = new System.Drawing.Point(74, 85);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.Size = new System.Drawing.Size(188, 20);
            this.TxtProveedorNombre.TabIndex = 8;
            // 
            // TxtProveedorCedula
            // 
            this.TxtProveedorCedula.Location = new System.Drawing.Point(79, 133);
            this.TxtProveedorCedula.Name = "TxtProveedorCedula";
            this.TxtProveedorCedula.Size = new System.Drawing.Size(175, 20);
            this.TxtProveedorCedula.TabIndex = 9;
            // 
            // TxtProveedorEmail
            // 
            this.TxtProveedorEmail.Location = new System.Drawing.Point(410, 33);
            this.TxtProveedorEmail.Name = "TxtProveedorEmail";
            this.TxtProveedorEmail.Size = new System.Drawing.Size(236, 20);
            this.TxtProveedorEmail.TabIndex = 10;
            // 
            // TxtProveedorDireccion
            // 
            this.TxtProveedorDireccion.Location = new System.Drawing.Point(434, 78);
            this.TxtProveedorDireccion.Multiline = true;
            this.TxtProveedorDireccion.Name = "TxtProveedorDireccion";
            this.TxtProveedorDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorDireccion.Size = new System.Drawing.Size(231, 23);
            this.TxtProveedorDireccion.TabIndex = 11;
            // 
            // CbTipoProovedor
            // 
            this.CbTipoProovedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoProovedor.FormattingEnabled = true;
            this.CbTipoProovedor.Location = new System.Drawing.Point(468, 183);
            this.CbTipoProovedor.Name = "CbTipoProovedor";
            this.CbTipoProovedor.Size = new System.Drawing.Size(212, 21);
            this.CbTipoProovedor.TabIndex = 13;
            // 
            // TxtProveedorNotas
            // 
            this.TxtProveedorNotas.Location = new System.Drawing.Point(417, 123);
            this.TxtProveedorNotas.Multiline = true;
            this.TxtProveedorNotas.Name = "TxtProveedorNotas";
            this.TxtProveedorNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorNotas.Size = new System.Drawing.Size(248, 30);
            this.TxtProveedorNotas.TabIndex = 14;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Lime;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(332, 557);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(125, 48);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CProveedorID
            // 
            this.CProveedorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorID.DataPropertyName = "ProveedorID";
            this.CProveedorID.HeaderText = "Codigo";
            this.CProveedorID.Name = "CProveedorID";
            this.CProveedorID.ReadOnly = true;
            // 
            // CProveedorNombre
            // 
            this.CProveedorNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorNombre.DataPropertyName = "ProveedorNombre";
            this.CProveedorNombre.HeaderText = "Nombre";
            this.CProveedorNombre.Name = "CProveedorNombre";
            this.CProveedorNombre.ReadOnly = true;
            // 
            // CProveedorCedula
            // 
            this.CProveedorCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorCedula.DataPropertyName = "ProveedorCedula";
            this.CProveedorCedula.HeaderText = "Cedula";
            this.CProveedorCedula.Name = "CProveedorCedula";
            this.CProveedorCedula.ReadOnly = true;
            // 
            // CProveedorEmail
            // 
            this.CProveedorEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorEmail.DataPropertyName = "ProveedorEmail";
            this.CProveedorEmail.HeaderText = "Correo";
            this.CProveedorEmail.Name = "CProveedorEmail";
            this.CProveedorEmail.ReadOnly = true;
            // 
            // CProveedorDireccion
            // 
            this.CProveedorDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorDireccion.DataPropertyName = "ProveedorDireccion";
            this.CProveedorDireccion.HeaderText = "Direccion";
            this.CProveedorDireccion.Name = "CProveedorDireccion";
            this.CProveedorDireccion.ReadOnly = true;
            // 
            // CProveedorNotas
            // 
            this.CProveedorNotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorNotas.DataPropertyName = "ProveedorNotas";
            this.CProveedorNotas.HeaderText = "Notas";
            this.CProveedorNotas.Name = "CProveedorNotas";
            this.CProveedorNotas.ReadOnly = true;
            // 
            // FrmGestionProovedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CboxVerProovedoresActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionProovedores";
            this.Text = "FrmGestionProovedores";
            this.Load += new System.EventHandler(this.FrmGestionProovedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CboxVerProovedoresActivos;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtProveedorCedula;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.TextBox TxtProveedorID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbTipoProovedor;
        private System.Windows.Forms.TextBox TxtProveedorDireccion;
        private System.Windows.Forms.TextBox TxtProveedorEmail;
        private System.Windows.Forms.TextBox TxtProveedorNotas;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorNotas;
    }
}