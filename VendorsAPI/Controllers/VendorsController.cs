using Microsoft.AspNetCore.Mvc;
using Vendors.Application.VendorsApp;
using Vendors.Domain.Dtos;

namespace VendorsAPI.Controllers
{
    public class VendorsController : Controller
    {
        private readonly IVendorsApp _vendorsApp;

        public VendorsController(IVendorsApp vendorsApp)
        {
            this._vendorsApp = vendorsApp;
        }

        [HttpPost("/vendor")]
        public async Task<IActionResult> CreateVendor([FromBody]VendorDto vendor)
        {
            var result = await _vendorsApp.AddVendor(vendor);
            return Ok(result);
        }

        [HttpGet("/vendors")]
        public async Task<IActionResult> GetVendors()
        {
            var result = await _vendorsApp.GetAllVendors();
            return Ok(result);
        }
    }
}
