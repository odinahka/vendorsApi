using Vendors.Domain.Dtos;
using Vendors.Domain.Models;

namespace Vendors.Application.VendorsApp
{
    public interface IVendorsApp
    {
        Task<Vendor> AddVendor(VendorDto vendorDto);
        Task<IEnumerable<Vendor>> GetAllVendors();
    }
}