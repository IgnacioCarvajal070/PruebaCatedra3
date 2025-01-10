using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Dtos;

namespace PruebaCatedra3.src.Services.Interfaces
{
    /// <summary>
    /// Interfaz del servicio de autenticación
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Inicia sesion
        /// </summary>
        /// <param name="userLoginForm">Formulario de inicio de sesión ingresado por el usuario</param>
        /// <returns>Formulario que contiene los datos del usuario y el token de autenticación</returns>
        Task<UserLoginDTO> Login(UserLoginForm userLoginForm);
        /// <summary>
        /// Registra un usuario
        /// </summary>
        /// <param name="userRegisterDTO">Formulario de registro ingresado por el usuario</param>
        /// <returns>Formulario que contiene los datos del usuario y el token de autenticación</returns>
        Task<UserLoginDTO> Register(UserRegisterDTO userRegisterDTO);
    }
}