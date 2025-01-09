using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using BCrypt.Net;
using PruebaCatedra3.src.Dtos;
using PruebaCatedra3.src.Models;
using PruebaCatedra3.src.Repository.Interfaces;
using PruebaCatedra3.src.Services.Interfaces;
using PruebaCatedra3.src.Mappers;

namespace PruebaCatedra3.src.Services.Implements
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public AuthService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }
        private string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new ("Id", user.Id.ToString()),
                new ("Email", user.Email),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                    _configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
        public async Task<UserLoginDTO> Login(UserLoginForm userLoginForm)
        {
            var user = await _userRepository.GetUser(userLoginForm.Email);
            if (user == null){
                throw new Exception("Usuario no encontrado, verifique sus credenciales");
            }
            var result = BCrypt.Net.BCrypt.Verify(userLoginForm.Password, user.Password);
            if (!result){
                throw new Exception("Contraseña incorrecta");
            }
            var token = CreateToken(user);
            var loggedUser = UserMapper.toDto(user);
            return new UserLoginDTO{
                User = loggedUser,
                Token = token
            };
        }

        public async Task<UserLoginDTO> Register(UserRegisterDTO userRegisterDTO)
        {
            var user = UserMapper.toModelFromRegister(userRegisterDTO);
            if (_userRepository.verifyUser(user.Email).Result){
                throw new Exception("El email ya esta en uso");
            }
            var salt = BCrypt.Net.BCrypt.GenerateSalt(12);
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password, salt);
            await _userRepository.CreateUser(user);
            var token = CreateToken(user);
            var loggedUser = UserMapper.toDto(user);
            return new UserLoginDTO{
                User = loggedUser,
                Token = token
            };
        }
    }
}