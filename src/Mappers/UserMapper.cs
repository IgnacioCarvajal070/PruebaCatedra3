using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using PruebaCatedra3.src.Dtos;
using PruebaCatedra3.src.Models;

namespace PruebaCatedra3.src.Mappers
{
    public class UserMapper
    {
        public static UserDTO toDto(User user){
            return new UserDTO{
                Id = user.Id,
                Email = user.Email,
                Name = user.Name
            };
        }
        public static User toModelFromRegister (UserRegisterDTO userRegisterDTO){
            return new User{
                Email = userRegisterDTO.Email,
                Name = userRegisterDTO.Name,
                Password = userRegisterDTO.Password
            };
        }
    }
}