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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }
        

       
        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            //TxtContrasennia.UseSystemPasswordChar=false;


        }

        private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            //TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                string usuario=TxtEmail.Text.Trim();
                string contrasenia=TxtContrasennia.Text.Trim();
                //tratar de validar que los datos sean los correctos

                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasenia);

               if (Globales.MiUsuarioGlobal.UsuarioId >0)
                {
                    Globales.MiFormPrincipal.Show();
                    this.Hide();
                }

               else
                {
                    MessageBox.Show("Usiario o Contraseña sin incorrectas", "Error en validacion", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();
                }







            }
            else
            {
                MessageBox.Show("Faltan datos requeridos!", "Error de Validacion", MessageBoxButtons.OK);

            }
            
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.Alt & e.KeyCode== Keys.A)
            {
                BtnIngresoDirecto.Visible = true;
            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.MiFormPrincipal.Show();
            this.Hide();
        }
    }
}

