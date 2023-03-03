using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        Usuario_Rol MiRolTipo { get; set; }

        public Usuario ()
        {
            MiRolTipo = new Usuario_Rol ();


        }
        
}
    public bool Agregar ()
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
    public bool ConsultarPorID()
    {
        bool R = false;
        return R;
    }
    public bool ConsultarPorCedula()
    {
        bool R = false;
        return R;
    }
    public bool ConsultarPorEmail()
    {
        bool R = false;
        return R;
    }
    public DataTable ListarActivos()
    {
        DataTable R = new DataTable();
        return R;
    }

    public DataTable ListarInactivos()
    {
        DataTable R = new DataTable();
        return R;
    }

    public Usuario ValidarUsuario(string pEmail, string pContrasennia)
    {
        Usuario R = new Usuario();
        return R;

    }
}
