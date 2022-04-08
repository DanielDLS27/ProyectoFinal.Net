using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CdisMart_BLL;

namespace CdisMart
{
    public partial class Login : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuarioValido())
            {
                Response.Redirect("~/Auctions/auction_s.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Sesión", "alert('Usuario y/o contraseña incorrectos')", true);
            }
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/Usuarios/usuario_i.aspx");
        }

        #endregion

        #region Metodos

        public bool usuarioValido()
        {
            bool acceso = false;

            UsuarioBLL userBLL = new UsuarioBLL();
            DataTable dtUsuario = new DataTable();

            dtUsuario = userBLL.consultarUsuario(txtUsuarioName.Text, txtContraseña.Text);

            if(dtUsuario.Rows.Count > 0)
            {
                Session["Usuario"] = dtUsuario;
                acceso = true;

            }

            return acceso;
        }

        #endregion

        
    }
}