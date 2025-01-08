using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCatedra3.src.Dtos
{
    public class UserLoginDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; } = string.Empty;
    }
}