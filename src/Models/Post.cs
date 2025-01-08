using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PruebaCatedra3.src.Models
{
    public class Post : IdentityUser
    {
        public string Title { get; set; } = string.Empty;
        public DateOnly date { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageId { get; set; }
    }
}