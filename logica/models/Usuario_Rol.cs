using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace logica.models
{
    public class Usuario_Rol
    {
        //primero se digitan las propiedades de las clases
        public int UsuarioRol_ID { get; set; }
    }
    //private int myVar;

    //public int MyProperty
    //{
    //    get { return myVar; }
    //    set { myVar = value; }
    //}

    public string UsuarioRolDescripcion { get; set; }

    //Por ultimo se escriben las funciones y metodos 
    public DataTable Listar ()
    {
        DataTable R = new DataTable();

        return R;

    }
}




