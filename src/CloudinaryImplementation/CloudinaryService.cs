using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;

namespace PruebaCatedra3.src.CloudinaryImplementation
{
    /// <summary>
    /// Implementacion de la interfaz ICloudinaryService
    /// </summary>
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;
        public CloudinaryService(IOptions<CloudinarySettings> cloudinarySettings)
        {
            var settings = cloudinarySettings.Value;
            var account = new Account(
                settings.CloudName,
                settings.ApiKey,
                settings.ApiSecret
            );
            _cloudinary = new Cloudinary(account);
        }
        public async Task<string> UploadImageAsync(IFormFile image)
        {
            if (image.Length > 5* 1024 * 1024){
                throw new Exception("Solo se permiten imagenes con tamaño de hasta 5MB");
            }
            var validExtensions = new string[] {".jpg", ".png"};
            var extension = Path.GetExtension(image.FileName);
            if (!validExtensions.Contains(extension)){
                throw new Exception("Solo se permiten imagenes con extension .jpg o .png");
            }
            using var stream = image.OpenReadStream();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(image.FileName, stream),
                Transformation = new Transformation().Quality("auto").FetchFormat("auto")
            };
            var uploadResult = await _cloudinary.UploadAsync(uploadParams);
            return uploadResult.SecureUrl.ToString();
        }
    }
}