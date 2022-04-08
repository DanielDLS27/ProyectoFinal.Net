using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CdisMart_DAL;

namespace CdisMart_BLL
{
    public class UsuarioBLL
    {
        public DataTable consultarUsuario(string nombreUsuario, string contraseña)
        {
            UsuarioDAL usuario = new UsuarioDAL();
            return usuario.consultarUsuario(nombreUsuario, contraseña);
        }

        public void agregarUsuario(Usuario paramUsuario)
        {
            UsuarioDAL usuario = new UsuarioDAL();
            usuario.agregarUsuario(paramUsuario);
        }
    }
}
