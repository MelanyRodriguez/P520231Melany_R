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
    public partial class FrmMDIcs : Form
    {
        public FrmMDIcs()
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
    }
}
