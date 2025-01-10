using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Dtos;
using PruebaCatedra3.src.Models;

namespace PruebaCatedra3.src.Services.Interfaces
{
    /// <summary>
    /// Interfaz del servicio de publicaciones
    /// </summary>
    public interface IPostService
    {
        /// <summary>
        /// Obtiene todas las publicaciones
        /// </summary>
        /// <returns>Lista de todas las publicaciones</returns>
        Task<IEnumerable<PostDTO>> GetPosts();
        /// <summary>
        /// Crea una publicación
        /// </summary>
        /// <param name="postDTO">Formulario ingresado por el usuario para crear un Post</param>
        /// <param name="userId">Id del usuario</param>
        /// <returns>Formulario con los datos del post creado</returns>
        Task<PostDTO> CreatePost(PostCreateDTO postDTO, string userId);
    }
}