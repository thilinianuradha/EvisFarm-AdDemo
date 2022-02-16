using AdDemo.Services.AcceptedRequests;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcceptedRequestsController : ControllerBase
    {
        private readonly IAcceptedRequestRepository _service;
        private readonly IMapper _mapper;
        public AcceptedRequestsController(IAcceptedRequestRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult GetAcceptedRequests()
        {
            var acceptedRequests = _service.AllAcceptedRequests();
            return Ok(acceptedRequests);
        }
        [HttpGet("{id}")]
        public IActionResult GetAcceptedRequest(int id)
        {
            var acceptedRequest = _service.GetAcceptedRequest(id);
            if (acceptedRequest is null)
            {
                return NotFound();
            }
            return Ok(acceptedRequest);
        }
    }
}
