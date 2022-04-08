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
    public partial class auction_titulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    int id = int.Parse(Request.QueryString["AuctionId"]);
                    cargarSubasta(id);

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

        public void cargarSubasta(int id)
        {
          AuctionBLL auctionBLL = new AuctionBLL();
            Auction auction = new Auction();

            auction = auctionBLL.obtenerSubasta(id);

            lblProductName.Text = auction.ProductName;
            lblDescription.Text = auction.Description;
            lblStart.Text = auction.StartDate.ToString();
            lblEnd.Text = auction.EndDate.ToString();
            lblHigh.Text = auction.HighestBid.ToString();
            lblWinner.Text = auction.Winner.ToString();
            lblUserId.Text = auction.UserId.ToString();

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