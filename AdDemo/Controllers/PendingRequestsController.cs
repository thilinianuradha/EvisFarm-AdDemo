using AdDemo.Services.PendingRequests;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PendingRequestsController : ControllerBase
    {
        private readonly IPendingRequestRepository _service;
        private readonly IMapper _mapper;
        public PendingRequestsController(IPendingRequestRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult GetPendingRequests()
        {
            var pendingRequests = _service.AllPendingRequests();
            return Ok(pendingRequests);
        }
        [HttpGet("{id}")]
        public IActionResult GetPendingRequest(int id)
        {
            var pendingRequest = _service.GetAPendingRequest(id);
            if (pendingRequest is null)
            {
                return NotFound();
            }
            return Ok(pendingRequest);
        }
    }
}
