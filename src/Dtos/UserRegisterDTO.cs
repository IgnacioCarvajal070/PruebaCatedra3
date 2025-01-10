using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{
    /// <summary>
    /// DTO para el formulario de registro del usuario
    /// </summary>
    public class UserRegisterDTO
    {
        /// <summary>
        /// Email del usuario
        /// </summary>
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        public string Password { get; set; } = string.Empty;
        /// <summary>
        /// Confirmación de la contraseña
        /// </summary>
        public string ConfirmPassword { get; set; } = string.Empty;
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}