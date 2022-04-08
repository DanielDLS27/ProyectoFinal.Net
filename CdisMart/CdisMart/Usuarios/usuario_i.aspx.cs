using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CdisMart_BLL;
using CdisMart_DAL;

namespace CdisMart.Usuarios
{
    public partial class usuario_i : System.Web.UI.Page
    {

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtContraseña2.Text.Equals(txtContraseña.Text)){
                agregarUsuario();
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('Usuario agregado exitosamente.')", true);
            Response.Redirect("../Login.aspx");
            }
            else Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('La contraseña no coincide!')", true);
        }

        #endregion

        #region Metodos

        public void agregarUsuario()
        {

            

            UsuarioBLL userBLL = new UsuarioBLL();

            Usuario usuario = new Usuario();

            usuario.Name = txtNombre.Text;
            usuario.Email = txtEmail.Text;
            usuario.UserName = txtUsuarioName.Text;
            usuario.Contraseña = txtContraseña.Text;

            userBLL.agregarUsuario(usuario);
           
        }

        #endregion

        
    }
}