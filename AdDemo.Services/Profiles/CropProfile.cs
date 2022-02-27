using AdDemo.Models;
using AdDemo.Services.Crops.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Profiles
{
    public class CropProfile : AutoMapper.Profile
    {
        public CropProfile()
        {
            CreateMap<Crop, CropDto>();

            CreateMap<CreateCropDto, Crop>();

            CreateMap<UpdateCropDto, Crop>();


        }
    }
}
