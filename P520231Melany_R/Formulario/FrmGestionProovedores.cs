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
    public partial class FrmGestionProovedores : Form
    {

        private logica.models.Proovedor MiProovedorLocal { get; set; }

        private DataTable ListaProovedores { get; set; }

        public FrmGestionProovedores()
        {
            InitializeComponent();

            MiProovedorLocal=new logica.models.Proovedor();
            ListaProovedores = new DataTable();
        }

        private void FrmGestionProovedores_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarListaTipos();
            CargarListaProveedores();
            
        }


        private void CargarListaProveedores()
        {

          ListaProovedores= new DataTable();
            if (CboxVerProovedoresActivos.Checked)
            {
                ListaProovedores = MiProovedorLocal.ListarActivos();
            }
            else
            {
                ListaProovedores = MiProovedorLocal.ListarInactivos();
            }

            DgLista.DataSource=ListaProovedores;


        }
        private void CargarListaTipos()
        {
            logica.models.TipoProovedor MiProovedor = new logica.models.TipoProovedor();    
            DataTable dt = new DataTable();
            dt = MiProovedor.Listar();

            if (dt != null && dt.Rows.Count >0)
            {
                CbTipoProovedor.ValueMember = "ID";
                CbTipoProovedor.DisplayMember = "Descrip";
                CbTipoProovedor.DataSource= dt;
                CbTipoProovedor.SelectedIndex = -1;
            }

        }

        private void LimpiarFormulario()
        {
            TxtProveedorID.Clear();
            TxtProveedorNombre.Clear();
            TxtProveedorCedula.Clear();
            TxtProveedorEmail.Clear();
            TxtProveedorDireccion.Clear();
            TxtProveedorNotas.Clear();
            CbTipoProovedor.SelectedIndex = -1;


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MiProovedorLocal = new logica.models.Proovedor();

            MiProovedorLocal.ProovedorNombre= TxtProveedorNombre.Text.Trim();
            MiProovedorLocal.ProovedorCedula = TxtProveedorCedula.Text.Trim();
            MiProovedorLocal.ProovedorEmail = TxtProveedorEmail.Text.Trim();
            MiProovedorLocal.ProovedorDireccion = TxtProveedorDireccion.Text.Trim();
            MiProovedorLocal.ProovedorNotas = TxtProveedorNotas.Text.Trim();

            MiProovedorLocal.MiTipoProovedor.PreoovedorTipoID = Convert.ToInt32(CbTipoProovedor.SelectedValue);


            string msg = string.Format("¿Esta seguro de guardar el proveedor {0}?", MiProovedorLocal.ProovedorNombre);

            DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes) 
            {
                bool ok = MiProovedorLocal.Agregar();

                if (ok) 
                {
                    MessageBox.Show("Proovedor guardado correctamente!", "(:", MessageBoxButtons.OK);

                    LimpiarFormulario();
                    CargarListaProveedores();
                }

                else
                {
                    MessageBox.Show("Proovedor no guardado correctamente!", "):", MessageBoxButtons.OK);
                }

            }







        }
    }
}
