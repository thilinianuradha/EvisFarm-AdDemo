using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdDemo.Services.Vendors;


namespace AdDemo.Controllers
{
    [Route("api/[[Vendors]]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly IVendorRepository _service;
        public VendorsController(IVendorRepository service)
        {
            _service = service;

        }
        [HttpGet]
        public IActionResult GetVendors()
        {
            var vendors = _service.GetAllVendors();
            return Ok(vendors);
        }
        [HttpGet("{id}")]
        public IActionResult GetVendor(int id)
        {
            var vendor = _service.GetVendor(id);
            return Ok(vendor);
        }

    }
}
