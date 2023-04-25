using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231Melany_R.Formulario
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDIcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gESTIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasPorFecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Codigo para que gestion de usuarios se muestre solo una vez
            if (!Globales.MiFormGestionUsuarios.Visible)
            {
                Globales.MiFormGestionUsuarios = new Usuario_Gestion();
                Globales.MiFormGestionUsuarios.Show();
            }
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

            string InfoUsuario = string.Format("{0}-{1}({2})",


                                              Globales.MiUsuarioGlobal.UsuarioNombre,
                                              Globales.MiUsuarioGlobal.UsuarioCorreo,
                                              Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolDescripcion); ;
            lblUsuario.Text = InfoUsuario;

            switch (Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRol_ID)
            {
                case 1:
                    break;

                    case 2:
                    gestionDeUsuariosToolStripMenuItem.Visible = false;
                    rolesDeUsuarioToolStripMenuItem.Visible=false;
                    tiposDeProovedorToolStripMenuItem.Visible=false;
                    tiposDeCompraToolStripMenuItem.Visible = false;
                    break;
            }









        }

        private void registroDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Globales.MiFormRegistroCompra.Visible)
            {
                Globales.MiFormRegistroCompra=new FrmRegistroCompras();

                Globales.MiFormRegistroCompra.Show();
            }
        }

        private void gestionDeProovedporesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionProovedores.Visible)
            {
                Globales.MiFormGestionProovedores = new FrmGestionProovedores();

                Globales.MiFormGestionProovedores.Show();
            }
        }
    }
}
