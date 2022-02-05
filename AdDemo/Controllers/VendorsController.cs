using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdDemo.Services.Vendors;
using AdDemo.Services.Vendors.ViewModels;
using AdDemo.Models;
using AutoMapper;

namespace AdDemo.Controllers
{
    [Route("api/[[Vendors]]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly IVendorRepository _service;
        private readonly IMapper _mapper;
        public VendorsController(IVendorRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;

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

        [HttpPost]
        public ActionResult<VendorDto> CreateVendor(CreateVendorDto vendor)
        {

            var vendorEntity = _mapper.Map<Vendor>(vendor);
            var newVendor = _service.AddVendor(vendorEntity);


            var vendorForReturn = _mapper.Map<VendorDto>(newVendor);
            return CreatedAtRoute("GetVendor", new { id = vendorForReturn.Id }, value: vendorForReturn);
        }
        [HttpPut]
        public ActionResult UpdateVendor(int Id, UpdateVendorDto vendor)
        {
            var UpdatingVendor = _service.GetVendor(Id);
            if (UpdatingVendor is null)
            {
                return NotFound();
            }
            _mapper.Map(vendor, UpdatingVendor);
            _service.UpdateVendor(UpdatingVendor);

            return NoContent();
        }

        [HttpDelete]

        public ActionResult DeleteVendor(int Id)
        {
            var DeletingVendor = _service.GetVendor(Id);
            if (DeletingVendor is null)
            {
                return NotFound();
            }
            _service.DeleteVendor(DeletingVendor);
            return NoContent();
        }

    }
}
