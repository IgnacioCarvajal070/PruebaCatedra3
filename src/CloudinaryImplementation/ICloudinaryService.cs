using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.CloudinaryImplementation
{
    /// <summary>
    /// Interfaz para la implementacion de Cloudinary
    /// </summary>
    public interface ICloudinaryService
    {
        /// <summary>
        /// Metodo para subir una imagen a Cloudinary
        /// </summary>
        /// <param name="image">Imagen a subir</param>
        /// <returns>String con la url resultante</returns>
        Task<string> UploadImageAsync(IFormFile image);
    }
}