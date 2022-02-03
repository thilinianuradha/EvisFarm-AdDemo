using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdDemo.Services.Crops;

namespace AdDemo.Controllers
{
    [Route("api/[[crops]]")]
    [ApiController]
    public class CropsController : ControllerBase
    {
        private readonly ICropRepository _service;
        public CropsController(ICropRepository service)
        {
            _service = service;

        }
        [HttpGet]
        public IActionResult GetCrops()
        {
            var crops = _service.GetAllCrops();
            return Ok(crops);
        }
        [HttpGet("{id}")]
        public IActionResult GetCrop(int id)
        {
            var crop = _service.GetCrop(id);
            if (crop is null)
            {
                return NotFound(); 
            }
            return Ok(crop);
        }
    }
}
