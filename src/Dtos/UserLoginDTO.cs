using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{
    /// <summary>
    /// DTO para el formulario que retorna el login de un usuario
    /// </summary>
    public class UserLoginDTO
    {
        /// <summary>
        /// Datos del usuario logeado
        /// </summary>
        public UserDTO User { get; set; }
        /// <summary>
        /// Token de autenticación
        /// </summary>
        public string Token { get; set; } = string.Empty;
    }
}