using logica.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231Melany_R.Formulario
{
    public partial class FrmCompraBuscar : Form
    {

        DataTable ListaProductos { get; set; }
        Producto MiProductoLocal { get; set; }

        public FrmCompraBuscar()
        {
            InitializeComponent();

            ListaProductos= new DataTable();
            MiProductoLocal= new Producto();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

        private void FrmCompraBuscar_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

       private void LlenarLista()
        {
            ListaProductos = new DataTable();
            ListaProductos= MiProductoLocal.ListarEnBusqueda();
            DgvLista.DataSource= ListaProductos;
            DgvLista.ClearSelection();
        }
    }
}
