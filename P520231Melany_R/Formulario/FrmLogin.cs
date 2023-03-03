using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

       
        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar=false;


        }

        private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Globales.MiFormPrincipal.Show();
            this.Hide();
        }
    }
}

