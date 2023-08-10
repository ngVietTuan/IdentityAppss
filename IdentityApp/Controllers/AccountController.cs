using IdentityApp.Models;
using IdentityApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace IdentityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JWTServices _jWTServices;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(JWTServices jWTServices, SignInManager<User> signInManager, UserManager<User> userManager) 
        {
            _jWTServices = jWTServices;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        #region Private Helper Methods
        private UserDto CreateApplicationUserDto(User user)
        {
            return new UserDto
        }
    }
}
