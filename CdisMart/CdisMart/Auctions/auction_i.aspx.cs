using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CdisMart_BLL;
using CdisMart_DAL;

namespace CdisMart.Auctions
{
    public partial class auction_i : System.Web.UI.Page
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

                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }

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

        public void insertarSubasta()
        {
            AuctionBLL BLL = new AuctionBLL();
            Auction subasta = new Auction();

            subasta.ProductName = txtProductName.Text;
            subasta.Description = txtDes.Text;
            subasta.StartDate = Convert.ToDateTime(txtInicio.Text);
            subasta.EndDate = Convert.ToDateTime(txtFin.Text);
            subasta.Winner = 0;
            subasta.HighestBid = 0;

            DataTable dt = new DataTable();
            dt = (DataTable)Session["Usuario"];

            int id = int.Parse(dt.Rows[0]["UserId"].ToString());

            subasta.UserId = id;

            BLL.insertarSubasta(subasta);
            limpiarInputs();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('Subasta agregada con exito')", true);

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            insertarSubasta();
        }

        public void limpiarInputs()
        {
            txtProductName.Text = "";
            txtDes.Text = "";
            txtFin.Text = "";
            txtInicio.Text = "";
        }
    }
}