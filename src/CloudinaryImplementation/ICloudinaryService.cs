using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.CloudinaryImplementation
{
    public interface ICloudinaryService
    {
        Task<string> UploadImageAsync(IFormFile image);
    }
}