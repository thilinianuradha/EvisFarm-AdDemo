using AdDemo.Models;
using AdDemo.Services.Users;
using AdDemo.Services.Users.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdDemo.Controllers
{
    [Route("api/[[Users]]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _service;
        private readonly IMapper _mapper;


        public UsersController(IUserRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public ActionResult<ICollection<UserDto>> GetUsers()
        {
            var users = _service.AllUsers();
            return Ok(users);
        }

        [HttpGet("{id}", Name = "GetAUser")]
        public IActionResult GetUser(int id)
        {
            var user = _service.GetAUser(id);
            return Ok(user);
        }

        [HttpPost]
        public ActionResult<UserDto> CreateUser(CreateUserDto user)
        {

            var userEntity = _mapper.Map<User>(user);
            var newUser = _service.AddUser(userEntity);


            var userForReturn = _mapper.Map<UserDto>(newUser);
            return CreatedAtRoute("GetUser", new { id = userForReturn.Id }, value: userForReturn);
        }

        [HttpPut]
        public ActionResult UpdateUser(int Id, UpdateUserDto user)
        {
            var UpdatingUser = _service.GetAUser(Id);
            if (UpdatingUser is null)
            {
                return NotFound();
            }
            _mapper.Map(user, UpdatingUser);
            _service.UpdateUser(UpdatingUser);

            return NoContent();
        }

        [HttpDelete]

        public ActionResult DeleteUser(int Id)
        {
            var DeletingUser = _service.GetAUser(Id);
            if (DeletingUser is null)
            {
                return NotFound();
            }
            _service.DeleteUser(DeletingUser);
            return NoContent();
        }
    }
}
