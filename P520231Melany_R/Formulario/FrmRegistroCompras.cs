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
    public partial class FrmRegistroCompras : Form
    {

     

       public Compra MiCompraLocal { get; set; }
        public DataTable ListaProductos { get; set; }
        public FrmRegistroCompras()
        {
            InitializeComponent();
            MiCompraLocal= new Compra();
            ListaProductos= new DataTable();
           
        }

        private void FrmRegistroCompras_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarTiposDeCompra();
            LimpiarForm();


        }

        private void CargarTiposDeCompra()
        {
            DataTable dtTiposCompra= new DataTable();
            dtTiposCompra = MiCompraLocal.MiTipoCompra.Listar();

            CboxCompraTipo.ValueMember = "id";
            CboxCompraTipo.DisplayMember = "Descripcion";
            CboxCompraTipo.DataSource = dtTiposCompra;
            CboxCompraTipo.SelectedIndex = -1;
           
        }

        private void LimpiarForm()
        {
            TxtProovedorNombre.Clear();
            TxtNotas.Clear();
            TxtTotal.Text = "0";
            TxtTotalCantidad.Text = "0";
            CboxCompraTipo.SelectedIndex = 1;

            ListaProductos= new DataTable();

            ListaProductos = MiCompraLocal.CargarEsquemaDetalle();
            DgvLista.DataSource = ListaProductos;
        }



        private void BtnProovedorBuscar_Click(object sender, EventArgs e)
        {
            Form FormBusquedaProovedor = new FrmProovedorBuscar();
            DialogResult respuesta = FormBusquedaProovedor.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                TxtProovedorNombre.Text = MiCompraLocal.MiProovedor.ProovedorNombre;
            }
        }


        private void Totalizar()
        {
            if (ListaProductos.Rows.Count > 0)
            {
                decimal TotalItems = 0;
                decimal totalMonto = 0;

                foreach (DataRow row in ListaProductos.Rows)
                {
                    TotalItems += Convert.ToDecimal(row["Cantidad"]);
                    totalMonto += Convert.ToDecimal(row["PrecioVentaUnitario"]);
                }


                TxtTotalCantidad.Text = TotalItems.ToString();
                TxtTotal.Text = string.Format("{0:C2}", totalMonto);
            }
        }

        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {

            if (DgvLista.SelectedRows.Count==1)
            {
                DataGridViewRow row = DgvLista.SelectedRows[0];

                int IdProducto = Convert.ToInt32(row.Cells["CProductoID"].Value);

                string NombreProducto = Convert.ToString(row.Cells["CProductoNombre"].Value);

                string CodigoBarras = Convert.ToString(row.Cells["CProductoCodigoBarras"].Value);

                decimal Precio = Convert.ToDecimal(row.Cells["CPrecioVentaUnitario"].Value);
                decimal Cantidad = NumUDCantidad.Value;

                DataRow MiFila= Globales.MiFormRegistroCompra.ListaProductos.NewRow();
                MiFila["ProductoID"] = IdProducto;
                MiFila["Cantidad"] = Cantidad;
                MiFila["PrecioVentaUnitario"] = Precio;
                MiFila["ProductoNombre"] = NombreProducto;
                MiFila["ProductoCodigoBarras"] = CodigoBarras;

                Globales.MiFormRegistroCompra.ListaProductos.Rows.Add(MiFila);
                DialogResult= DialogResult.OK;


            }

            Form MiFormBusquedaItem = new FrmCompraBuscar();
            DialogResult respuesta = MiFormBusquedaItem.ShowDialog();
            if ( respuesta == DialogResult.OK )
            {
                DgvLista.DataSource = ListaProductos;
                Totalizar();
            }
        }

        private void BtnCrearCompra_Click(object sender, EventArgs e)
        {

            if (ValidarCompra())
            {
                MiCompraLocal.MiTipoCompra.CompraTipoID = Convert.ToInt32(CboxCompraTipo.SelectedValue);
                MiCompraLocal.CompraNotas= TxtNotas.Text.Trim();
                MiCompraLocal.MiUsuario.UsuarioId = 2;

                TrasladoDetalleListaVisualAObjetoCompra();

                if (MiCompraLocal.Agregar())
                {
                    MessageBox.Show("Compra creada correctamente!!", "(:", MessageBoxButtons.OK);

                    LimpiarForm();
                }












            }










        }

       private void TrasladoDetalleListaVisualAObjetoCompra()

        {
            foreach (DataRow fila in ListaProductos.Rows)
            {
                CompraDetalle nuevodetalle = new CompraDetalle();
                nuevodetalle.MiProducto.ProductoId = Convert.ToInt32(fila["ProductoID"]);
                nuevodetalle.Cantidad= Convert.ToDecimal(fila["Cantidad"]);
                nuevodetalle.PrecioUnitario = Convert.ToDecimal(fila["PrecioVentaUnitario"]);

                MiCompraLocal.ListaDetalles.Add(nuevodetalle);
            }
        }











      private bool ValidarCompra ()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProovedorNombre.Text.Trim()) &&
                CboxCompraTipo.SelectedIndex>=0 &&
                ListaProductos.Rows.Count >0)

            {
                R= true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtProovedorNombre.Text.Trim()))

                {
                    MessageBox.Show("Se debe seleccionar un proovedor", "Error en la validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (CboxCompraTipo.SelectedIndex==1)

                {
                    MessageBox.Show("Se debe seleccionar un tipo de compra", "Error en la validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (ListaProductos.Rows.Count==0)

                {
                    MessageBox.Show("Debe haber al menos una fila en el detalle", "Error en la validacion", MessageBoxButtons.OK);
                    return false;
                }



            }


            return R;
        }








    }
}
