using AdDemo.Models;
using AdDemo.Services.UserProfiles;
using AdDemo.Services.UserProfiles.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdDemo.Controllers
{
    [Route("api/[[UserProfiles]]")]
    [ApiController]
    public class UserProfilesController : ControllerBase
    {
        private readonly IUserProfileRepository _service;
        private readonly IMapper _mapper;


        public UserProfilesController(IUserProfileRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public ActionResult<ICollection<UserProfileDto>> GetUserProfiles()
        {
            var userprofiles = _service.AllUserProfiles();
            return Ok(userprofiles);
        }

        [HttpGet("{id}", Name = "GetAUserProfile")]
        public IActionResult GetUserProfile(int id)
        {
            var userprofile = _service.GetAUserProfile(id);
            return Ok(userprofile);
        }

        [HttpPost]
        public ActionResult<UserProfileDto> CreateUserProfile(CreateUserProfileDto userprofile)
        {

            var userprofileEntity = _mapper.Map<Models.UserProfile>(userprofile);
            var newUserProfile = _service.AddUserProfile(userprofileEntity);


            var userprofileForReturn = _mapper.Map<UserProfileDto>(newUserProfile);
            return CreatedAtRoute("GetUserProfile", new { id = userprofileForReturn.Id }, value: userprofileForReturn);
        }

        [HttpPut]
        public ActionResult UpdateUserProfile(int Id, UpdateUserProfileDto userprofile)
        {
            var UpdatingUserProfile = _service.GetAUserProfile(Id);
            if (UpdatingUserProfile is null)
            {
                return NotFound();
            }
            _mapper.Map(userprofile, UpdatingUserProfile);
            _service.UpdateUserProfile(UpdatingUserProfile);

            return NoContent();
        }

        [HttpDelete]

        public ActionResult DeleteUserProfile(int Id)
        {
            var DeletingUserProfile = _service.GetAUserProfile(Id);
            if (DeletingUserProfile is null)
            {
                return NotFound();
            }
            _service.DeleteUserProfile(DeletingUserProfile);
            return NoContent();
        }
    }
}
