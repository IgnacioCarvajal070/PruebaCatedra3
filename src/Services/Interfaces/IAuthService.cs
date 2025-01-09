using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Dtos;

namespace PruebaCatedra3.src.Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserLoginDTO> Login(UserLoginForm userLoginForm);
        Task<UserLoginDTO> Register(UserRegisterDTO userRegisterDTO);
    }
}