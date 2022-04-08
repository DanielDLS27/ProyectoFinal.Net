using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CdisMart_DAL
{
    public class AuctionDAL
    {
        CdisMartEntities modelo;

        public AuctionDAL()
        {
            modelo = new CdisMartEntities();
        }

        public List<object> cargarSubastas()
        {
            var subastas = from mSubastas in modelo.Auction
                           select new
                           {
                               AuctionId = mSubastas.AuctionId,
                               ProductName = mSubastas.ProductName,
                               Description = mSubastas.Description,
                               StartDate = mSubastas.StartDate,
                               EndDate = mSubastas.EndDate
                           };
            return subastas.AsEnumerable<object>().ToList();
        }

        public void insertarSubasta(Auction subasta)
        {
            modelo.Auction.Add(subasta);
            modelo.SaveChanges();
        }

        public Auction obtenerSubasta(int subastaId)
        {
            var subasta = (from a in modelo.Auction
                          where     a.AuctionId == subastaId
                          select a).FirstOrDefault();
            return subasta;
        }

    }
}
