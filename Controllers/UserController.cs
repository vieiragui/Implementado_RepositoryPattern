using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestandoRepositoryPattern.Model;
using TestandoRepositoryPattern.Repository.Interface;

namespace TestandoRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser()
        {
            var user = new User(Guid.NewGuid(), "Guilherme", "guilherme@gmail.com");
            await _userRepository.AddAsync(user);

            return Ok(user);
        }
    }
}