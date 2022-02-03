using AdDemo.Models;
using AdDemo.Services.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Profiles
{
   public class AdvertisementProfile : Profile
    {
        public AdvertisementProfile()
        {
            CreateMap<Advertisement, AdvertisementDto>()
            .ForMember(dest => dest.NameofOwner,
            opt => opt.MapFrom(src => $"{src.CreatedBy}"));

            CreateMap<CreateAdvertisementDto, Advertisement>();

            CreateMap<UpdateAdvertisementDto, Advertisement>();
        }
    }
}
