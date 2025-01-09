using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaCatedra3.src.Dtos;
using PruebaCatedra3.src.Services.Interfaces;
namespace PruebaCatedra3.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

       [HttpPost("login")]
        public async Task<ActionResult<UserLoginDTO>> Login([FromBody] UserLoginForm loginForm)
        {
            try {
                var response = await _authService.Login(loginForm);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserLoginDTO>> Register([FromBody] UserRegisterDTO userRegisterDTO)
        {
            try {
                var response = await _authService.Register(userRegisterDTO);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
    }
}