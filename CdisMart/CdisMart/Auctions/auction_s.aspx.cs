using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CdisMart_BLL;

namespace CdisMart.Auctions
{
    public partial class auction_s : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    DataTable dt = new DataTable();
                    dt = (DataTable)Session["Usuario"];

                    string NameUser = dt.Rows[0]["Name"].ToString();
                    lblUser.Text = NameUser.ToString();

                    grd_subastas.DataSource = cargarSubastas();
                    grd_subastas.DataBind();
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }

            }
          
        }

        public List<object> cargarSubastas()
        {
            AuctionBLL subBLL = new AuctionBLL();
            List<object> listSubastas = new List<object>();

            listSubastas = subBLL.cargarSubastas();

            return listSubastas;
        }

        protected void grd_subastas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "btn_historial")
            {
                Response.Redirect("~/Auctions/auction_record.aspx?AuctionId=" + e.CommandArgument);
            }
            else
            {
                Response.Redirect("~/Auctions/auction_titulo.aspx?AuctionId=" + e.CommandArgument);
            }
        }

        public bool sesionIniciada()
        {
            if (Session["Usuario"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}