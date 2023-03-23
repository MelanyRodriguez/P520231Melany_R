using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace logica.models
{
    public class categoriaProducto
    {
        public int CategoriaID { get; set; }
        public string CategoriaDescripcion { get; set; }


        public DataTable listar()
        {
            DataTable R = new DataTable();
            return R;
        }













    }
   
}
