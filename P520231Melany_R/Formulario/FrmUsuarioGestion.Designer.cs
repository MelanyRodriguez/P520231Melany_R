namespace P520231Melany_R.Formulario
{
    partial class Usuario_Gestion
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
            this.buscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.DGLista = new System.Windows.Forms.DataGridView();
            this.UsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRolDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccionUsuario = new System.Windows.Forms.Label();
            this.txtUsuarioDireccion = new System.Windows.Forms.TextBox();
            this.Usuari = new System.Windows.Forms.Label();
            this.CBRolesUsuario = new System.Windows.Forms.ComboBox();
            this.txtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.txtUsuarioContrseniaContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.txtUsuarioCedula = new System.Windows.Forms.TextBox();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.AutoSize = true;
            this.buscar.Location = new System.Drawing.Point(16, 7);
            this.buscar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(68, 25);
            this.buscar.TabIndex = 0;
            this.buscar.Text = "Buscar";
            this.buscar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.Color.Lime;
            this.txtBuscar.Location = new System.Drawing.Point(96, 7);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(347, 33);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Location = new System.Drawing.Point(469, 3);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(194, 29);
            this.CboxVerActivos.TabIndex = 2;
            this.CboxVerActivos.Text = "VerUsuariosActivos";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            // 
            // DGLista
            // 
            this.DGLista.AllowUserToAddRows = false;
            this.DGLista.AllowUserToDeleteRows = false;
            this.DGLista.AllowUserToOrderColumns = true;
            this.DGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioID,
            this.UsuarioNombre,
            this.UsuarioCorreo,
            this.UsuarioCedula,
            this.UsuarioTelefono,
            this.UsuarioRolDescripcion});
            this.DGLista.Location = new System.Drawing.Point(12, 49);
            this.DGLista.MultiSelect = false;
            this.DGLista.Name = "DGLista";
            this.DGLista.ReadOnly = true;
            this.DGLista.RowHeadersVisible = false;
            this.DGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGLista.Size = new System.Drawing.Size(764, 150);
            this.DGLista.TabIndex = 3;
            this.DGLista.VirtualMode = true;
            this.DGLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGLista_CellClick);
            this.DGLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGLista_DataBindingComplete);
            // 
            // UsuarioID
            // 
            this.UsuarioID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UsuarioID.DataPropertyName = "UsuarioID";
            this.UsuarioID.HeaderText = "Cod.Usuario";
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.ReadOnly = true;
            this.UsuarioID.Width = 120;
            // 
            // UsuarioNombre
            // 
            this.UsuarioNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsuarioNombre.DataPropertyName = "UsuarioNombre";
            this.UsuarioNombre.HeaderText = "Nombre";
            this.UsuarioNombre.Name = "UsuarioNombre";
            this.UsuarioNombre.ReadOnly = true;
            // 
            // UsuarioCorreo
            // 
            this.UsuarioCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UsuarioCorreo.DataPropertyName = "UsuarioCorreo";
            this.UsuarioCorreo.HeaderText = "Correo";
            this.UsuarioCorreo.Name = "UsuarioCorreo";
            this.UsuarioCorreo.ReadOnly = true;
            this.UsuarioCorreo.Width = 130;
            // 
            // UsuarioCedula
            // 
            this.UsuarioCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UsuarioCedula.DataPropertyName = "UsuarioCedula";
            this.UsuarioCedula.HeaderText = "Cedula";
            this.UsuarioCedula.Name = "UsuarioCedula";
            this.UsuarioCedula.ReadOnly = true;
            this.UsuarioCedula.Width = 120;
            // 
            // UsuarioTelefono
            // 
            this.UsuarioTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UsuarioTelefono.DataPropertyName = "UsuarioTelefono";
            this.UsuarioTelefono.HeaderText = "Telefono";
            this.UsuarioTelefono.Name = "UsuarioTelefono";
            this.UsuarioTelefono.ReadOnly = true;
            this.UsuarioTelefono.Width = 120;
            // 
            // UsuarioRolDescripcion
            // 
            this.UsuarioRolDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UsuarioRolDescripcion.DataPropertyName = "UsuarioRolDescripcion";
            this.UsuarioRolDescripcion.HeaderText = "Decpripcion";
            this.UsuarioRolDescripcion.Name = "UsuarioRolDescripcion";
            this.UsuarioRolDescripcion.ReadOnly = true;
            this.UsuarioRolDescripcion.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtDireccionUsuario);
            this.groupBox1.Controls.Add(this.txtUsuarioDireccion);
            this.groupBox1.Controls.Add(this.Usuari);
            this.groupBox1.Controls.Add(this.CBRolesUsuario);
            this.groupBox1.Controls.Add(this.txtUsuarioCorreo);
            this.groupBox1.Controls.Add(this.txtUsuarioContrseniaContrasenia);
            this.groupBox1.Controls.Add(this.txtUsuarioTelefono);
            this.groupBox1.Controls.Add(this.txtUsuarioCedula);
            this.groupBox1.Controls.Add(this.txtUsuarioNombre);
            this.groupBox1.Controls.Add(this.txtUsuarioID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Usuario);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(21, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DetalleUsuario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(620, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 46);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(467, 227);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 46);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(314, 224);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 46);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Lime;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(161, 226);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 46);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(8, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 46);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.AutoSize = true;
            this.txtDireccionUsuario.Location = new System.Drawing.Point(385, 187);
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(97, 25);
            this.txtDireccionUsuario.TabIndex = 17;
            this.txtDireccionUsuario.Text = "Direccion:";
            // 
            // txtUsuarioDireccion
            // 
            this.txtUsuarioDireccion.Location = new System.Drawing.Point(488, 184);
            this.txtUsuarioDireccion.Multiline = true;
            this.txtUsuarioDireccion.Name = "txtUsuarioDireccion";
            this.txtUsuarioDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsuarioDireccion.Size = new System.Drawing.Size(164, 34);
            this.txtUsuarioDireccion.TabIndex = 16;
            // 
            // Usuari
            // 
            this.Usuari.AutoSize = true;
            this.Usuari.Location = new System.Drawing.Point(385, 130);
            this.Usuari.Name = "Usuari";
            this.Usuari.Size = new System.Drawing.Size(104, 25);
            this.Usuari.TabIndex = 15;
            this.Usuari.Text = "UsuarioRol";
            // 
            // CBRolesUsuario
            // 
            this.CBRolesUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRolesUsuario.FormattingEnabled = true;
            this.CBRolesUsuario.Location = new System.Drawing.Point(506, 130);
            this.CBRolesUsuario.Name = "CBRolesUsuario";
            this.CBRolesUsuario.Size = new System.Drawing.Size(159, 33);
            this.CBRolesUsuario.TabIndex = 14;
            // 
            // txtUsuarioCorreo
            // 
            this.txtUsuarioCorreo.Location = new System.Drawing.Point(497, 79);
            this.txtUsuarioCorreo.Name = "txtUsuarioCorreo";
            this.txtUsuarioCorreo.Size = new System.Drawing.Size(162, 33);
            this.txtUsuarioCorreo.TabIndex = 13;
            // 
            // txtUsuarioContrseniaContrasenia
            // 
            this.txtUsuarioContrseniaContrasenia.Location = new System.Drawing.Point(495, 40);
            this.txtUsuarioContrseniaContrasenia.Name = "txtUsuarioContrseniaContrasenia";
            this.txtUsuarioContrseniaContrasenia.Size = new System.Drawing.Size(164, 33);
            this.txtUsuarioContrseniaContrasenia.TabIndex = 12;
            this.txtUsuarioContrseniaContrasenia.UseSystemPasswordChar = true;
            // 
            // txtUsuarioTelefono
            // 
            this.txtUsuarioTelefono.Location = new System.Drawing.Point(113, 153);
            this.txtUsuarioTelefono.Name = "txtUsuarioTelefono";
            this.txtUsuarioTelefono.Size = new System.Drawing.Size(203, 33);
            this.txtUsuarioTelefono.TabIndex = 11;
            // 
            // txtUsuarioCedula
            // 
            this.txtUsuarioCedula.Location = new System.Drawing.Point(113, 114);
            this.txtUsuarioCedula.Name = "txtUsuarioCedula";
            this.txtUsuarioCedula.Size = new System.Drawing.Size(203, 33);
            this.txtUsuarioCedula.TabIndex = 10;
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Location = new System.Drawing.Point(113, 72);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(203, 33);
            this.txtUsuarioNombre.TabIndex = 9;
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Location = new System.Drawing.Point(113, 33);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.ReadOnly = true;
            this.txtUsuarioID.Size = new System.Drawing.Size(203, 33);
            this.txtUsuarioID.TabIndex = 8;
            this.txtUsuarioID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "RolUsuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contrasenia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(6, 33);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(82, 25);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario:";
            // 
            // Usuario_Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGLista);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.buscar);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Usuario_Gestion";
            this.Text = "Usuario_Gestion";
            this.Load += new System.EventHandler(this.Usuario_Gestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.DataGridView DGLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox txtUsuarioID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuarioCorreo;
        private System.Windows.Forms.TextBox txtUsuarioContrseniaContrasenia;
        private System.Windows.Forms.TextBox txtUsuarioTelefono;
        private System.Windows.Forms.TextBox txtUsuarioCedula;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.ComboBox CBRolesUsuario;
        private System.Windows.Forms.Label txtDireccionUsuario;
        private System.Windows.Forms.TextBox txtUsuarioDireccion;
        private System.Windows.Forms.Label Usuari;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRolDescripcion;
    }
}