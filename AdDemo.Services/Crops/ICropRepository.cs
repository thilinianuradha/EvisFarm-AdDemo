using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdDemo.Models;

namespace AdDemo.Services.Crops
{
    public interface ICropRepository
    {
        public List<Crop> GetAllCrops();
        public Crop GetCrop(int id);
    }
}
