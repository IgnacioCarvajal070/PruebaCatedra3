using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PruebaCatedra3.src.Models
{
    /// <summary>
    /// Modelo de publicación
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Identificador de la publicación
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Titulo de la publicación
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Fecha de creacion de la publicación
        /// </summary>
        public DateTime date { get; set; }
        /// <summary>
        /// Url de la imagen
        /// </summary>
        public string? ImageUrl { get; set; }
        /// <summary>
        /// Identificador del usuario que publico la publicación
        /// </summary>
        public string UserId { get; set; } = string.Empty;
        /// <summary>
        /// Usuario que publico la publicación
        /// </summary>
        public User User { get; set; } = null!;
    }
}