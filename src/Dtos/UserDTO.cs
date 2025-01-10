using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{
    /// <summary>
    /// DTO del usuario
    /// </summary>
    public class UserDTO
    {
        /// <summary>
        /// Id del usuario
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Email del usuario
        /// </summary>
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string Name { get; set; } = string.Empty;
    
    }
}