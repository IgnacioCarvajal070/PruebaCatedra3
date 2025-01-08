using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Dtos;
using PruebaCatedra3.src.Services.Interfaces;

namespace PruebaCatedra3.src.Services.Implements
{
    public class AuthService : IAuthService
    {
        public Task<UserLoginDTO> Login(UserLoginDTO userLoginDTO)
        {
            throw new NotImplementedException();
        }

        public Task<UserRegisterDTO> Register(UserRegisterDTO userRegisterDTO)
        {
            throw new NotImplementedException();
        }
    }
}