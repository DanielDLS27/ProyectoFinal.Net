using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CdisMart_DAL;

namespace CdisMart_BLL
{
    public class AuctionBLL
    {
        public List<object> cargarSubastas()
        {
            AuctionDAL subasta = new AuctionDAL();
            return subasta.cargarSubastas();
        }

        public void insertarSubasta(Auction subasta)
        {
            AuctionDAL auction_dal = new AuctionDAL();
            auction_dal.insertarSubasta(subasta);
        }

        public Auction obtenerSubasta(int subastaId)
        {
            AuctionDAL auction_dal = new AuctionDAL();
            return auction_dal.obtenerSubasta(subastaId);
        }
    }
}
