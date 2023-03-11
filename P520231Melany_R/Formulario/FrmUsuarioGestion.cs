using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231Melany_R.Formulario
{
    public partial class Usuario_Gestion : Form
    {
        public Usuario_Gestion()
        {
            InitializeComponent();
        }

        private void Usuario_Gestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;



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
    }
}
