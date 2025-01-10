using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PruebaCatedra3.src.Models
{   
    /// <summary>
    /// Modelo de usuario
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}