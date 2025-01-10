using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{
    public class PostDTO
    {
        public string Title { get; set; } = string.Empty;
        public DateTime date { get; set; }
        public string? ImageUrl { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}