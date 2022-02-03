using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdDemo.DataAccess;

namespace AdDemo.Services.Crops
{
    
    public class CropSqlServerService : ICropRepository
    {
        private readonly AdvertisementDbContext _context = new AdvertisementDbContext();
        public List<Crop> GetAllCrops()
        {
            return _context.Crops.ToList();
        }

       

        public Crop GetCrop(int id)
        {
          return _context.Crops.Find(id);
        }
    }
}
