using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Vendors
{
    public interface IVendorRepository
    {
        public List<Vendor> GetAllVendors();
        public Vendor GetVendor(int id);
        public Vendor AddVendor(Vendor vendor);
    }

}
