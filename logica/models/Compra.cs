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
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime ComptraFecha { get; set; }
        public int CompraNumero { get; set; }
        public string CompraNotas { get; set; }
        public bool Activo { get; set; }

        public Usuario MiUsuario { get; set;}
        public Proovedor MiProovedor { get; set; }
        public TipoCompra MiTipoCompra { get; set; }

        public List<CompraDetalle> ListaDetalles { get; set; }
        public Compra ()
        {
            MiUsuario= new Usuario ();
            MiProovedor= new Proovedor ();
            MiTipoCompra= new TipoCompra ();
            ListaDetalles= new List<CompraDetalle> ();
        }

      public DataTable CargarEsquemaDetalle()
        {
            DataTable R = new DataTable ();
            conexion MiCnn = new conexion();

            R = MiCnn.EjecutarSELECT("SPCompraDetalleEsquema", true);
            R.PrimaryKey = null;

            return R;
        }

        public bool Agregar ()
        {
            bool R=false;
            conexion MiCnn =new conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdProveedor", this.MiProovedor.ProovedorId));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdTipoCompra", this.MiTipoCompra.CompraTipoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdUsuario", this.MiUsuario.UsuarioId));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.CompraNotas));

            Object retorno = MiCnn.EjecutarSELECTEscalar("SPCompraAgregar");


            int IDCreada;

            if (retorno!=null)

            {
                try
                {
                    IDCreada= Convert.ToInt32(retorno.ToString());

                    this.CompraId= IDCreada;

                    foreach (CompraDetalle item in this.ListaDetalles)
                    {
                        conexion MiCnnDetalle =new conexion();
                        
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IdCompra",IDCreada));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@@IdProducto", item.MiProducto.ProductoId));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.Cantidad));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Precio ", item.PrecioUnitario));

                        MiCnnDetalle.EjecutarInsertUpdateDelete("SPCompraDetalleAgregar");
                    }

                    R = true;

                }
                catch (Exception) 
                {
                    throw;
                }

                


            }

            return R;


        }



    }
}
