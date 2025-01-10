using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{   
    /// <summary>
    /// DTO para el post
    /// </summary>
    public class PostDTO
    {
        /// <summary>
        /// Titulo del post
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Fecha de creacion del post
        /// </summary>
        public DateTime date { get; set; }
        /// <summary>
        /// Url de la imagen
        /// </summary>
        public string? ImageUrl { get; set; }
        /// <summary>
        /// Nombre del usuario que publico el post
        /// </summary>
        public string UserName { get; set; } = string.Empty;
    }
}