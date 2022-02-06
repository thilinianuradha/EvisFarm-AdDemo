using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Buyers
{
    public interface IBuyerRepository
    {
        public List<Buyer> AllBuyers();
        public Buyer GetABuyer(int id);
        public Buyer AddBuyer(Buyer buyer);
        public void UpdateBuyer(Buyer buyer);
        public void DeleteBuyer(Buyer buyer);
    }
}
