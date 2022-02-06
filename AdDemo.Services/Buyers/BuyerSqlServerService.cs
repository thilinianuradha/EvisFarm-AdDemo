using AdDemo.DataAccess;
using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Buyers
{
    public class BuyerSqlServerService : IBuyerRepository
    {
        private readonly AdvertisementDbContext _context = new AdvertisementDbContext();
        public List<Buyer> AllBuyers()
        {
            return _context.Buyers.Where(m => !m.IsDeleted).ToList();
        }
        public Buyer GetABuyer(int id)
        {
            return _context.Buyers.Find(id);
        }

        public Buyer AddBuyer(Buyer buyer)
        {
            _context.Buyers.Add(buyer);
            _context.SaveChanges();

            return _context.Buyers.Find(buyer.Id);

        }
        public void UpdateBuyer(Buyer buyer)
        {
            _context.SaveChanges();

        }

        public void DeleteBuyer(Buyer buyer)
        {
            _context.Remove(buyer);
            _context.SaveChanges();

        }

       
    }
}
