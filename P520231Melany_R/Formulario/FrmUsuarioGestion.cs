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
            MiUsuarioLocal=new logica.models.Usuario();
            ListaUsuarios=new DataTable();
        }

        private void Usuario_Gestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarListaRoles();
            CargarListaUsuarios();
        }
        private void CargarListaUsuarios()
            {
            ListaUsuarios= new DataTable();
            ListaUsuarios = MiUsuarioLocal.ListarActivos();
            if(CboxVerActivos.Checked) {
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
            DataTable dt= new DataTable();
            dt=MiRol.Listar();

            if  (dt != null && dt.Rows.Count >0)
                 {
                CBRolesUsuario.ValueMember = "ID";
                CBRolesUsuario.DisplayMember = "Descrip";
                CBRolesUsuario.DataSource = dt;
                CBRolesUsuario.SelectedIndex= -1;
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
            if (DGLista.SelectedRows.Count==1)
            {
                DataGridViewRow MiFila= DGLista.SelectedRows[0];
            int IDUsuario = Convert.ToInt32(MiFila.Cells["UsuarioID"].Value);
            MiUsuarioLocal = new logica.models.Usuario();
            MiUsuarioLocal.UsuarioId= IDUsuario;
            MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();
            if (MiUsuarioLocal!=null && MiUsuarioLocal.UsuarioId >0)

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
    }
}

