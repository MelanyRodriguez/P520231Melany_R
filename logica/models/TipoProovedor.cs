using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace logica.models
{
    public class TipoProovedor
    {
        public int PreoovedorTipoID { get; set; }
        public string ProovedorTipoDescripcion { get; set; }

        public DataTable Listar()
        {
         DataTable R = new DataTable();

            Servicios.conexion MiCnn= new Servicios.conexion();

            R = MiCnn.EjecutarSELECT("SPProveedorTipoListar");


            return R;
        }
}
}
