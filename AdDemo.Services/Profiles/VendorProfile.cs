using AdDemo.Models;
using AdDemo.Services.Vendors.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Profiles
{
    public class VendorProfile : Profile
    {
        public VendorProfile()
        {
            CreateMap<Vendor, VendorDto>();

            CreateMap<CreateVendorDto, Vendor>();

            CreateMap<UpdateVendorDto, Vendor>();


        }
    }
}
