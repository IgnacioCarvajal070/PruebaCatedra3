using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{
    public class PostCreateDTO
    {
        public string Title { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
    }
}