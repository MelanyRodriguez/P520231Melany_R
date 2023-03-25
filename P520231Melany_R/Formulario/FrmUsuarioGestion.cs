using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231Melany_R.Formulario
{
    public partial class Usuario_Gestion : Form
    {
        private logica.models.Usuario MiUsuarioLocal { get; set; }
        private DataTable ListaUsuarios { get; set; }





        public Usuario_Gestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new logica.models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void Usuario_Gestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarListaRoles();
            CargarListaUsuarios();
        }
        private void CargarListaUsuarios()
        {
            ListaUsuarios = new DataTable();
            ListaUsuarios = MiUsuarioLocal.ListarActivos();
            if (CboxVerActivos.Checked)
            {
                ListaUsuarios = MiUsuarioLocal.ListarActivos();
            }
            else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos();

            }

            DGLista.DataSource = ListaUsuarios;

        }

        private void CargarListaRoles()
        {
            logica.models.Usuario_Rol MiRol = new logica.models.Usuario_Rol();
            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CBRolesUsuario.ValueMember = "ID";
                CBRolesUsuario.DisplayMember = "Descrip";
                CBRolesUsuario.DataSource = dt;
                CBRolesUsuario.SelectedIndex = -1;
            }

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DGLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGLista.ClearSelection();
        }

        private void DGLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGLista.SelectedRows.Count == 1)
            {
                DataGridViewRow MiFila = DGLista.SelectedRows[0];
                int IDUsuario = Convert.ToInt32(MiFila.Cells["UsuarioID"].Value);
                MiUsuarioLocal = new logica.models.Usuario();
                MiUsuarioLocal.UsuarioId = IDUsuario;
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();
                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioId > 0)

                {
                    txtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioId);
                    txtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;
                    txtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;
                    txtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;
                    txtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;
                    txtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    CBRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRol_ID;

                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {

            txtUsuarioID.Clear();
            txtUsuarioNombre.Clear();
            txtUsuarioCedula.Clear();
            txtUsuarioTelefono.Clear();
            txtUsuarioCorreo.Clear();
            txtUsuarioContrseniaContrasenia.Clear();
            CBRolesUsuario.SelectedIndex = -1;
            txtUsuarioDireccion.Clear();
        }

        private bool ValidarDatosDigitados()
        {
            bool R = false;
            if(!string.IsNullOrEmpty(txtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(txtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(txtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(txtUsuarioCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(txtUsuarioContrseniaContrasenia.Text.Trim())&&
                CBRolesUsuario.SelectedIndex>-1)
            {

                 R = true;
            }
            else
            {
                //Falta nombre
                if(string.IsNullOrEmpty(txtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    txtUsuarioNombre.Focus();
                    return false;
                }

                //Falta cedula

                if (string.IsNullOrEmpty(txtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    txtUsuarioCedula.Focus();
                    return false;
                }
                //Falta telefono
                if (string.IsNullOrEmpty(txtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    txtUsuarioTelefono.Focus();
                    return false;
                }

                //Falta correo

                if (string.IsNullOrEmpty(txtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    txtUsuarioCorreo.Focus();
                    return false;
                }

                //Falta pasword

                if (string.IsNullOrEmpty(txtUsuarioContrseniaContrasenia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una contrasenia para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    txtUsuarioContrseniaContrasenia.Focus();
                    return false;
                }

                //Falta roll Usuario

                if (CBRolesUsuario.SelectedIndex==-1)
                {
                    MessageBox.Show("Debe seleccionar un rol para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    CBRolesUsuario.Focus();
                    return false;
                }
















            }

            return R;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

          if (ValidarDatosDigitados())
            {

            }







            bool CedulaOK;
            bool EmailOK;
            MiUsuarioLocal = new logica.models.Usuario();
            MiUsuarioLocal.UsuarioNombre = txtUsuarioNombre.Text.Trim();
            MiUsuarioLocal.UsuarioCedula = txtUsuarioCedula.Text.Trim();
            MiUsuarioLocal.UsuarioTelefono = txtUsuarioTelefono.Text.Trim();
            MiUsuarioLocal.UsuarioCorreo = txtUsuarioCorreo.Text.Trim();
            MiUsuarioLocal.UsuarioContrasenia = txtUsuarioContrseniaContrasenia.Text.Trim();
            MiUsuarioLocal.UsuarioNombre = txtUsuarioNombre.Text.Trim();
            MiUsuarioLocal.MiRolTipo.UsuarioRol_ID = Convert.ToInt32(CBRolesUsuario.SelectedValue);
            MiUsuarioLocal.UsuarioDireccion = txtUsuarioDireccion.Text.Trim();
            CedulaOK = MiUsuarioLocal.ConsultarPorCedula();
            EmailOK = MiUsuarioLocal.ConsultarPorEmail();
            if (CedulaOK == false && EmailOK == false)
            {
                string msg = string.Format("¿Esta seguro que desea agregar al usuario? {0}", MiUsuarioLocal.UsuarioNombre);
                DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    bool ok = MiUsuarioLocal.Agregar();
                    if (ok)
                    {
                        MessageBox.Show("Usuario guardado correctamente", "(:", MessageBoxButtons.OK);

                        LimpiarFormulario();
                        CargarListaUsuarios();

                    }
                    else
                    {
                        MessageBox.Show("El usuario no se pudo guardar", ":/", MessageBoxButtons.OK);
                    }
                }



            }
            else
            {
                if (CedulaOK)
                {
                    MessageBox.Show("ya existe un usuario con la cedula digitada", "Error en validacion", MessageBoxButtons.OK);
                    return;
                }
                if (EmailOK)
                {
                    MessageBox.Show("ya existe un usuario con ese correo", "Error en validacion", MessageBoxButtons.OK);
                    return;
                }

            }

        }

    }
}









    

















