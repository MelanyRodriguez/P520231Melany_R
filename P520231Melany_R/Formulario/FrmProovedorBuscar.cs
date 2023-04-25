using logica.models;
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
    public partial class FrmProovedorBuscar : Form
    {
        DataTable DtLista { get; set; }
        Proovedor MiProovedorLocal { get; set; }


        public FrmProovedorBuscar()
        {
            InitializeComponent();

            DtLista= new DataTable();
            MiProovedorLocal= new Proovedor();
        }

        private void FrmProovedorBuscar_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            DtLista= new DataTable();
            DtLista = MiProovedorLocal.Listar(true, TxtBuscar.Text.Trim());
            DgvLista.DataSource= DtLista;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                LlenarLista();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
          
            if (DgvLista.SelectedRows.Count==1)

            {
                DataGridViewRow row= DgvLista.SelectedRows[0];

                int IdProovedor= Convert.ToInt32(row.Cells["CProveedorID"].Value);
                string NombreProovedor = Convert.ToString(row.Cells["CProveedorNombre"].Value);

                Globales.MiFormRegistroCompra.MiCompraLocal.MiProovedor.ProovedorNombre = NombreProovedor;
                Globales.MiFormRegistroCompra.MiCompraLocal.MiProovedor.ProovedorId = IdProovedor;
            }




            DialogResult = DialogResult.OK;
        }
    }
}
