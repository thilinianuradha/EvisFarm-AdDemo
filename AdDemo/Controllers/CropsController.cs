using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdDemo.Services.Crops;
using AdDemo.Services.Crops.ViewModels;
using AdDemo.Models;
using AutoMapper;

namespace AdDemo.Controllers
{
    [Route("api/[[crops]]")]
    [ApiController]
    public class CropsController : ControllerBase
    {
        private readonly ICropRepository _service;
        private readonly IMapper _mapper;
        public CropsController(ICropRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;

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
       
        [HttpPost]
        public ActionResult<CropDto> CreateCrop(CreateCropDto crop)
        {

            var cropEntity = _mapper.Map<Crop>(crop);
            var newCrop = _service.AddCrop(cropEntity);


            var cropForReturn = _mapper.Map<CropDto>(newCrop);
            return CreatedAtRoute("GetCrop", new { id = cropForReturn.Id }, value: cropForReturn);
        }
        [HttpPut]
        public ActionResult UpdateCrop(int Id, UpdateCropDto crop)
        {
            var UpdatingCrop = _service.GetCrop(Id);
            if (UpdatingCrop is null)
            {
                return NotFound();
            }
            _mapper.Map(crop, UpdatingCrop);
            _service.UpdateCrop(UpdatingCrop);

            return NoContent();
        }
        [HttpDelete]

        public ActionResult DeleteCrop(int Id)
        {
            var DeletingCrop = _service.GetCrop(Id);
            if (DeletingCrop is null)
            {
                return NotFound();
            }
            _service.DeleteCrop(DeletingCrop);
            return NoContent();
        }
    }
}
