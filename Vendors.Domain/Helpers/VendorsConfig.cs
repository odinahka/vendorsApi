using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendors.Domain.Dtos;
using Vendors.Domain.Models;

namespace Vendors.Domain.Helpers
{
    public class VendorsConfig : Profile
    {
        public VendorsConfig()
        {
            CreateMap<Vendor, VendorDto>().ReverseMap();
        }
    }
}
