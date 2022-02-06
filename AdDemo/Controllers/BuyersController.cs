using AdDemo.Models;
using AdDemo.Services.Buyers;
using AdDemo.Services.Buyers.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdDemo.Controllers
{
    [Route("api/[[Buyers]]")]
    [ApiController]
    public class BuyersController : ControllerBase
    {
           
        private readonly IBuyerRepository _service;
        private readonly IMapper _mapper;


        public BuyersController(IBuyerRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public ActionResult<ICollection<BuyerDto>> GetBuyers()
        {
            var Buyers = _service.AllBuyers(); 

            var mappedBuyers = _mapper.Map<ICollection<BuyerDto>>(Buyers);

            return Ok(mappedBuyers);
        }

        [HttpGet("{id}", Name = "GetBuyer")]
        public IActionResult GetBuyer(int id)
        {

            var buyer = _service.GetABuyer(id);
            if (buyer is null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<BuyerDto>(buyer);
            return Ok(mappedAuthor);
        }

        [HttpPost]
        public ActionResult<BuyerDto> CreateBuyer(CreateBuyerDto buyer)
        {

            var buyerEntity = _mapper.Map<Buyer>(buyer);
            var newBuyer = _service.AddBuyer(buyerEntity);


            var buyerForReturn = _mapper.Map<BuyerDto>(newBuyer);
            return CreatedAtRoute("GetBuyer", new { id = buyerForReturn.Id }, value: buyerForReturn);
        }

        [HttpPut]
        public ActionResult UpdateBuyer(int Id, UpdateBuyerDto buyer)
        {
            var UpdatingBuyer = _service.GetABuyer(Id);
            if (UpdatingBuyer is null)
            {
                return NotFound();
            }
            _mapper.Map(buyer, UpdatingBuyer);
            _service.UpdateBuyer(UpdatingBuyer);

            return NoContent();
        }

        [HttpDelete]

        public ActionResult DeleteBuyer(int Id)
        {
            var DeletingBuyer = _service.GetABuyer(Id);
            if (DeletingBuyer is null)
            {
                return NotFound();
            }
            _service.DeleteBuyer(DeletingBuyer);
            return NoContent();
        }
    }
}

