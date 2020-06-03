using System.Collections.Generic;
using Cars.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebCars.Controllers
{
    [Route("user-list")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository _userRepository { get; set; }

        public UsersController(IUserRepository usersRepository)
        {
            _userRepository = usersRepository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userRepository.GetAll();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userRepository.Get(id);
        }

    }
}
