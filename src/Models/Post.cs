using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Models
{
    public class Post
    {
        public int id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateOnly date { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageId { get; set; }
        public int UserId { get; set; }
    }
}