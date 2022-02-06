
using AdDemo.Services.Advertisements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdDemo.Services.ViewModels;
using AutoMapper;
using AdDemo.Models;

namespace AdDemo.Controllers
{
    [Route("api/[[advertisements]]")]
    [ApiController]
    public class AdvertisementsController : ControllerBase
    {
        private readonly IAdvetisementRepository _service;
        private readonly IMapper _mapper;
     

        public AdvertisementsController(IAdvetisementRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;
            
        }

        [HttpGet]
        public ActionResult<ICollection<AdvertisementDto>> GetAdvertisements()
        {
            var Advertisements = _service.AllAdvertisements(); // Where ( t => t.Id == id );
         
            var mappedAdvertisements =  _mapper.Map<ICollection<AdvertisementDto>>(Advertisements);

            return Ok(mappedAdvertisements);
        }

        [HttpGet("{id}", Name ="GetAdvertisement")]
        public IActionResult GetAdvertisement(int id)
        {

            var advertisement = _service.GetAdvertisement(id);
            if (advertisement is null)
            {
                return NotFound();
            }

            var mappedVendor = _mapper.Map<AdvertisementDto>(advertisement);
            return Ok(mappedVendor);
        }

        [HttpPost]
        public ActionResult<AdvertisementDto> CreateAdvertisement(CreateAdvertisementDto advertisement)
        {

            var advertisementEntity = _mapper.Map<Advertisement>(advertisement);
            var newAdvertisement = _service.AddAdvertisement(advertisementEntity);
            

            var advertisementForReturn = _mapper.Map<AdvertisementDto>(newAdvertisement);
            return CreatedAtRoute("GetAdvertisement", new {id = advertisementForReturn.Id},value:advertisementForReturn );
        }

        [HttpPut]
        public ActionResult UpdateAdvertisement(int Id, UpdateAdvertisementDto advertisement)
        {
            var UpdatingAdvertisement = _service.GetAdvertisement(Id);
            if (UpdatingAdvertisement is null)
            {
                return NotFound ();
            }
            _mapper.Map(advertisement, UpdatingAdvertisement);
            _service.UpdateAdvertisement(UpdatingAdvertisement);

            return NoContent();
        }

        [HttpDelete]

        public ActionResult DeleteAdvertisement(int Id)
        {
            var DeletingAdvertisement = _service.GetAdvertisement(Id);
            if(DeletingAdvertisement is null)
            { 
                return NotFound ();
            }
            _service.DeleteAdvertisement(DeletingAdvertisement);
            return NoContent ();
        }
    }
}
