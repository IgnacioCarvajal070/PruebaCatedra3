using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.CloudinaryImplementation
{
    /// <summary>
    /// Clase para almacenar las credenciales de Cloudinary
    /// </summary>
    public class CloudinarySettings
    {
        /// <summary>
        /// Nombre de la nube de Cloudinary
        /// </summary>
        public string CloudName { get; set; } = string.Empty;
        /// <summary>
        /// Api Key de Cloudinary
        /// </summary>
        public string ApiKey { get; set; } = string.Empty;
        /// <summary>
        /// Api Secret de Cloudinary
        /// </summary>
        public string ApiSecret { get; set; } = string.Empty;
    }
}