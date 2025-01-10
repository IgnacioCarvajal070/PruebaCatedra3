using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{
    /// <summary>
    /// DTO para la creacion de un post
    /// </summary>
    public class PostCreateDTO
    {
        /// <summary>
        /// Titulo del post
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Url de la imagen
        /// </summary>
        public string? ImageUrl { get; set; } 
    }
}