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
    public partial class FrmRegistroCompras : Form
    {
        public FrmRegistroCompras()
        {
            InitializeComponent();
        }

        private void FrmRegistroCompras_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
        }
    }
}
