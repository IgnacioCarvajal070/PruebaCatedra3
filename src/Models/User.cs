using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PruebaCatedra3.src.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
    }
}