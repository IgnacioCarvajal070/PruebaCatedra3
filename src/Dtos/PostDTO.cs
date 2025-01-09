using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{
    public class PostDTO
    {
        public string Title { get; set; } = string.Empty;
        public DateOnly date { get; set; }
        public string? ImageUrl { get; set; }
        public string UserId { get; set; } = string.Empty;
    }
}