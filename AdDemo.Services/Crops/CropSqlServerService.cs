using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdDemo.DataAccess;
using AdDemo.Models;

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

        public Crop AddCrop(Crop crop)
        {
            _context.Crops.Add(crop);
            _context.SaveChanges();

            return _context.Crops.Find(crop.Id);

        }
        public void UpdateCrop(Crop crop)
        {
            _context.SaveChanges();

        }
        public void DeleteCrop(Crop crop)
        {
            _context.Remove(crop);
            _context.SaveChanges();

        }
    }
}
