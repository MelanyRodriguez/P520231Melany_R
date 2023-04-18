using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231Melany_R
{
    public static class Globales
    {

        public static Form MiFormPrincipal= new Formulario.FrmMDI();

        public static Formulario.Usuario_Gestion MiFormGestionUsuarios = new Formulario.Usuario_Gestion();
        
        public static logica.models.Usuario MiUsuarioGlobal= new logica.models.Usuario();
        public static Formulario.FrmRegistroCompras MiFormRegistroCompra= new Formulario.FrmRegistroCompras();
    }
}
