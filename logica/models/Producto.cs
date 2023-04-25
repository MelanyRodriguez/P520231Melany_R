using logica.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string ProductoNombre { get; set; }
        public string ProovedorCodigoBarras { get; set; }
        public decimal CantidadStock { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Activo { get; set; }


        public bool Agregar()
        {
            bool R = false;
            return R;
        }
        public bool Editar()
        {
            bool R = false;
            return R;
        }
        public bool Eliminar()
        {
            bool R = false;
            return R;
        }
        public Proovedor ConsultarPorCodigoDeBarras(string CodigoBarras)
        {
            Proovedor R = new Proovedor();
            return R;

        }
        public bool ListarActivos()
        {
            bool R = false;
            return R;
        }
        public bool ListarInactivos()
        {
            bool R = false;
            return R;
        }

        public DataTable ListarEnBusqueda()
        {
            DataTable R   = new DataTable();

            conexion MiCnn = new conexion();

            R = MiCnn.EjecutarSELECT("SPProductoBusquedaListar");


            return R;

        }

        public categoriaProducto MiCategoria;
    }
}
