using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendors.Domain.Dtos;
using Vendors.Domain.Models;
using Vendors.Persistence.Repository;

namespace Vendors.Application.VendorsApp
{
    public class VendorsApp : IVendorsApp
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public VendorsApp(ApplicationDbContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public async Task<Vendor> AddVendor(VendorDto vendorDto)
        {
            var vendor = _mapper.Map<Vendor>(vendorDto);
            _dbContext.Vendors.Add(vendor);
            await _dbContext.SaveChangesAsync();
            return vendor;
        }

        public async Task<IEnumerable<Vendor>> GetAllVendors()
        {
            return await _dbContext.Vendors.ToListAsync();
        }

    }
}
