﻿using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Crops
{
    public interface ICropRepository
    {
    
        public List<Crop> GetAllCrops();
        public Crop GetCrop(int id);
    }

}
