using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdDemo.DataAccess;

namespace AdDemo.Services.Advertisements
{
     public interface IAdvetisementRepository
    {
       
        public List<Advertisement> AllAdvertisements();
        public Advertisement GetAdvertisement(int id);
        public Advertisement AddAdvertisement(Advertisement advertisement);
        public void UpdateAdvertisement(Advertisement advertisement);
        public void DeleteAdvertisement(Advertisement advertisement);

    }
}
