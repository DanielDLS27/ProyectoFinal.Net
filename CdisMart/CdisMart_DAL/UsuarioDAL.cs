using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdisMart_DAL
{
    public class UsuarioDAL
    {
        CdisMartEntities modelo;

        public UsuarioDAL()
        {
            modelo = new CdisMartEntities();
        }
        public DataTable consultarUsuario(string nombreUsuario, string contraseña)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-AJ3H9PS\SQLEXPRESS;Database=CdisMart;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_consultarUsuario";
            command.Connection = connection;

            command.Parameters.AddWithValue("pUsuarioName", nombreUsuario);
            command.Parameters.AddWithValue("pContraseña", contraseña);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtUsuario = new DataTable();

            connection.Open();

            adapter.SelectCommand = command;
            adapter.Fill(dtUsuario);

            connection.Close();

            return dtUsuario;
        }

        public void agregarUsuario(Usuario usuario)
        {
            modelo.Usuario.Add(usuario);
            modelo.SaveChanges();
        }
    }
}
