using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using logica.Servicios;

using System.Data.SqlClient;

namespace logica.models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string UsuarioCorreo { get; set; }
        public string UsuarioContrasenia { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioCedula { get; set; }
        public string UsuarioTelefono { get; set; }
        public string UsuarioDireccion { get; set; }
        public bool Activo { get; set; }
        public Usuario_Rol MiRolTipo { get; set; }

        public Usuario ()
        {
            MiRolTipo = new Usuario_Rol ();


        }
        
    public bool Agregar ()
    {
        bool R = false;

            conexion MiCnn= new conexion ();
            crypto MiEncriptador = new crypto();
            string ContraseniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.UsuarioContrasenia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContraseniaEncriptada));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRol_ID));
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");

            if (resultado>0)
            {
                R = true;
            }
            return R;
    }
    public bool Editar()

    {
       


        bool R = false;

            conexion MiCnn = new conexion();

            crypto MiEncriptador = new crypto();
            string ContraseniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.UsuarioContrasenia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContraseniaEncriptada));


            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRol_ID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
    }
    public bool Eliminar()
    {
        bool R = false;

      conexion MiCnn =new conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("ID",this.UsuarioId));
            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioDesactivar");
            if (respuesta > 0)
            {
              R= true;
            }

           

        return R;
    }

   public bool ConsultarPorID()
    {
        bool R = false;

            conexion MiCnn = new conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)

            {
                R = true;

            }

            return R;
    }
        public Usuario ConsultarPorIDRetornaUsuario()
        {
            Usuario R = new Usuario();

            conexion MiCnn=new conexion();

            MiCnn.ListaDeParametros.Add (new SqlParameter ("@ID", this.UsuarioId));

            DataTable dt= new DataTable();
            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null &&dt.Rows.Count >0)

            {
                DataRow dr = dt.Rows[0];
                R.UsuarioId = Convert.ToInt32(dr["UsuarioID"]);
                R.UsuarioNombre = Convert.ToString(dr["UsuarioNombre"]);
                R.UsuarioCorreo = Convert.ToString(dr["UsuarioCorreo"]);
                R.UsuarioCedula = Convert.ToString(dr["UsuarioCedula"]);
                R.UsuarioTelefono= Convert.ToString(dr["UsuarioTelefono"]);
                R.UsuarioDireccion = Convert.ToString(dr["UsuarioDireccion"]);
                R.UsuarioContrasenia= string.Empty;

                R.MiRolTipo.UsuarioRol_ID = Convert.ToInt32(dr["UsuarioRolID"]);
                R.MiRolTipo.UsuarioRolDescripcion = Convert.ToString(dr["UsuarioRolDescripcion"]);






            }





            return R;
        }
        public bool ConsultarPorCedula()

    {
        bool R = false;

            conexion MiCnn= new conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula",this.UsuarioCedula));    

            DataTable consulta = new DataTable();
            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorCedula");
            if (consulta!= null && consulta.Rows.Count > 0)
            {
                R = true;
            }
        return R;
    }
    public bool ConsultarPorEmail()
            
    {
            bool R = false;
            conexion MiCnn = new conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));

            DataTable consulta = new DataTable();
            consulta = MiCnn.EjecutarSELECT("SPUsuarioConstarPorEmail");
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;

            }
            
         
            return R;
    }
    public DataTable ListarActivos(string pFiltroBusqueda)
    {
        DataTable R = new DataTable();

            conexion MiCnn= new conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", true));
            R = MiCnn.EjecutarSELECT("PSUsuarioListar");
        return R;
    }

    public DataTable ListarInactivos(string pFiltroBusqueda)
    {
        DataTable R = new DataTable();

            conexion MiCnn = new conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("PSUsuarioListar");
            return R;
    }

    public Usuario ValidarUsuario(string pEmail, string pContrasennia)
    {
        Usuario R = new Usuario();
        return R;

    }

















    }
}
