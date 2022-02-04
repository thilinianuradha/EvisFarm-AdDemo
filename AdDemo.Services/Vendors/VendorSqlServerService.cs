using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdDemo.DataAccess;

namespace AdDemo.Services.Vendors
{
    public class VendorSqlServerService : IVendorRepository
    {
        private readonly AdvertisementDbContext _context = new AdvertisementDbContext();
        public List<Vendor> GetAllVendors()
        {
           return _context.Vendors.ToList();
        }

        public Vendor GetVendor(int id)
        {
            return _context.Vendors.Find(id); 
        }
        public Vendor AddVendor(Vendor vendor)
        {
            _context.Vendors.Add(vendor);
            _context.SaveChanges();

            return _context.Vendors.Find(vendor.Id);

        }
    }
}
