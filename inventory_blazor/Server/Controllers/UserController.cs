using inventory_blazor.Shared.Interfaces;
using inventory_blazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inventory_blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public UserController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _dataAccessProvider.GetUsersAsync();
        }

        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _dataAccessProvider.GetUserByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            await _dataAccessProvider.AddUserAsync(user);
            return Ok();
        }
        [HttpPut]
        public async Task Put([FromBody] User user)
        {
            await _dataAccessProvider.UpdateUserAsync(user);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _dataAccessProvider.DeleteUserAsync(id);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User loginUser)
        {
            // Retrieve the user from the database based on the provided email
            var user = await _dataAccessProvider.GetUserByEmailAsync(loginUser.Email);

            // Check if the user exists and if the provided password matches the stored password
            if (user != null && user.Password == loginUser.Password)
            {
                // Authentication successful
                return Ok(user);
            }
            else
            {
                // Authentication failed
                return Unauthorized();
            }
        }



    }
}
