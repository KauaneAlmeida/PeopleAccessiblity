using DisabledPeopleRegister.Dtos.Users;
using DisabledPeopleRegister.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DisabledPeopleRegister.Controllers
{
    [Route("auth")]
    public class AuthController(IUsersService usersService) : Controller
    {
        [HttpPost("/register")]
        public IActionResult Register(CreateUserDto createUserDto)
        {
            usersService.AddUser(createUserDto);
            return Ok();
        }

        [HttpPost("/login")]
        public IActionResult Login(LogUserDto logUserDto)
        {
            var isCredentialsValid = usersService.CheckUserCredentials(logUserDto);
            return Ok(isCredentialsValid);
        }


    }
}