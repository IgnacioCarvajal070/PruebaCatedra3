using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Models;

namespace PruebaCatedra3.src.Repository.Interfaces
{
    /// <summary>
    /// Interfaz para el repositorio de posts
    /// </summary>
    public interface IPostRepository
    {
        /// <summary>
        /// Metodo para obtener todos los posts
        /// </summary>
        /// <returns>Lista de posts en la base de datos</returns>
        Task<IEnumerable<Post>> GetPosts();
        /// <summary>
        /// Metodo para ingresar un post en la base de datos
        /// </summary>
        /// <param name="post">Post a ingresar</param>
        /// <returns>Post ingresado</returns>|
        Task<Post> CreatePost(Post post);
    }
}