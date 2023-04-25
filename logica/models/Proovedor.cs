using logica.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.models
{
    public class Proovedor
    {
        public int ProovedorId { get; set; }
        public string ProovedorNombre { get; set; }
        public string ProovedorCedula { get; set; }
        public string ProovedorEmail { get; set; }
        public string ProovedorDireccion { get; set; }
        public string ProovedorNotas { get; set; }
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
        public Proovedor ConsultarPorCedula(string pCedula)
        {
            Proovedor R = new Proovedor();
            return R;

        }

        public Proovedor ConsultarPorEmail(string pEmail)
        {
            Proovedor R = new Proovedor();
            return R;

        }

        public Proovedor ConsultarPorID(int pID)
        {
            Proovedor R = new Proovedor();
            return R;

        }

        public DataTable Listar(bool verActivos=true, string FiltroBusqueda="")
        {
            DataTable R = new DataTable();
            conexion MiCnn= new conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", verActivos));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda ", FiltroBusqueda));
            R = MiCnn.EjecutarSELECT("SPProveedorListar");



            return R;
        }
        public TipoProovedor MiTipoProovedor;

        public Proovedor ()
        {
            MiTipoProovedor = new TipoProovedor();
        }





    }

}


