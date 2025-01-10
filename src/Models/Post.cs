using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PruebaCatedra3.src.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime date { get; set; }
        public string? ImageUrl { get; set; }
        public string UserId { get; set; } = string.Empty;
        public User User { get; set; } = null!;
    }
}