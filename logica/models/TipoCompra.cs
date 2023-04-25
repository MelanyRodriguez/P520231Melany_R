using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using logica.Servicios;

namespace logica.models
{
    public class TipoCompra
    {
        public int CompraTipoID { get; set; }
        public string CompraTipoDescripcion{ get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();


            conexion MiCnn = new conexion();

            R = MiCnn.EjecutarSELECT("SPTipoCompraListar");

            return R;
        }
}
}

