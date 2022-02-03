using AdDemo.DataAccess;
using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Advertisements
{
    public class AdvertisementSqlServerService : IAdvetisementRepository
    {
        private readonly AdvertisementDbContext _context = new AdvertisementDbContext();
        public List<Advertisement> AllAdvertisements()
        {
           return _context.Advertisements.Where(x => !x.IsDeleted).ToList();
        }

        public Advertisement GetAdvertisement(int id)

        {
           return _context.Advertisements.Find(id);
        }
        public Advertisement AddAdvertisement(Advertisement advertisement)
        {
            _context.Advertisements.Add(advertisement);
            _context.SaveChanges();

            return _context.Advertisements.Find(advertisement.Id);

        }
        public void UpdateAdvertisement(Advertisement advertisement)
        {
            _context.SaveChanges();

        }

        public void DeleteAdvertisement(Advertisement advertisement)
        {
           _context.Remove(advertisement);
            _context.SaveChanges();

        }
    }
}
