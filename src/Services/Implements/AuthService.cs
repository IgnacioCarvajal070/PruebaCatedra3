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
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email),
            };
            var tokenString = _configuration["AppSettings:Token"] ?? throw new ArgumentNullException("AppSettings:Token is not configured.");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenString));

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
            var result = BCrypt.Net.BCrypt.Verify(userLoginForm.Password, user.PasswordHash);
            if (!result){
                throw new Exception("Contraseña incorrecta");
            }
            var token = CreateToken(user);
            return new UserLoginDTO{
                User = new UserDTO{
                    Id = user.Id,
                    Email = user.Email,
                    Name = user.Name
                },
                Token = token
            };
        }

        public async Task<UserLoginDTO> Register(UserRegisterDTO userRegisterDTO)
        {
            if (_userRepository.verifyUser(userRegisterDTO.Email).Result){
                throw new Exception("El email ya esta en uso");
            }
            if (userRegisterDTO.Password != userRegisterDTO.ConfirmPassword){
                throw new Exception("Las contraseñas no coinciden");
            }
            var user = new User{
                Email = userRegisterDTO.Email,
                Name = userRegisterDTO.Name,
            };
            await _userRepository.CreateUser(user, userRegisterDTO.Password);
            var token = CreateToken(user);
            return new UserLoginDTO{
                User = new UserDTO{
                    Id = user.Id,
                    Email = user.Email,
                    Name = user.Name
                },
                Token = token
            };
        }
    }
}