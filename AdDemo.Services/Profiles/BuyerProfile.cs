using AdDemo.Models;
using AdDemo.Services.Buyers.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Profiles
{
    public class BuyerProfile : Profile
    {
        public BuyerProfile()
        {
            CreateMap<Buyer, BuyerDto>();

            CreateMap<CreateBuyerDto, Buyer>();

            CreateMap<UpdateBuyerDto, Buyer>();


        }
    }
}
