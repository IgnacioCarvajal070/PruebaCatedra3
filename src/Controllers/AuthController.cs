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
    /// <summary>
    /// Controlador para la autenticación de usuarios
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        /// <summary>
        /// Servicio de autenticación
        /// </summary>
        private readonly IAuthService _authService;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="authService"> Servicio de autenticación</param>
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        /// <summary>
        /// Metodo para loguear un usuario
        /// </summary>
        /// <param name="loginForm">Datos ingresados por el usuario</param>
        /// <returns>Formulario con los datos del usuario y el token de ingreso</returns>
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
        /// <summary>
        /// Metodo para registrar un usuario
        /// </summary>
        /// <param name="userRegisterDTO">Formulario ingresado por el usuario</param>
        /// <returns>Formulario con los datos del usuario y el token de ingreso</returns>

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