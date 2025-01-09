using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Models;

namespace PruebaCatedra3.src.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User?> GetUser(string email);
        Task<bool> CreateUser(User user, string password);
        Task<bool> verifyUser(string email);
        Task<string> getName(string id);
    }
}