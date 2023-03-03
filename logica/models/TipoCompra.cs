using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace logica.models
{
    internal class TipoCompra
    {
        public int CompraTipoID { get; set; }
        public string CompraTipoDescripcion{ get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            return R;
        }
}
}

