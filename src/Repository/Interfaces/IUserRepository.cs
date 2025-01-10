using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Models;

namespace PruebaCatedra3.src.Repository.Interfaces
{   
    /// <summary>
    /// Interfaz del repositorio de usuarios
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <returns>Lista con todos los usuarios</returns>
        Task<IEnumerable<User>> GetUsers();
        /// <summary>
        /// Obtiene un usuario por su email
        /// </summary>
        /// <param name="email">Email del usuario a buscar</param>
        /// <returns>Usuario encontrado, null en caso de no encontrar el usuario</returns>
        Task<User?> GetUser(string email);
        /// <summary>
        /// Crea un usuario
        /// </summary>
        /// <param name="user">Usuario a crear</param>
        /// <param name="password">Contraseña del usuario</param>
        /// <returns>True si el usuario fue creado, false en caso contrario</returns>
        Task<bool> CreateUser(User user, string password);
        /// <summary>
        /// Verifica si un usuario existe segun su email
        /// </summary>
        /// <param name="email">Email del usuario</param>
        /// <returns>True si encuentra al usuario, False en caso contrario</returns>
        Task<bool> verifyUser(string email);
        /// <summary>
        /// Obtiene el nombre de un usuario segun su id
        /// </summary>
        /// <param name="id">Id del usuario a buscar</param>
        /// <returns>Nombre del usuario encontrado</returns>
        Task<string> getName(string id);
    }
}