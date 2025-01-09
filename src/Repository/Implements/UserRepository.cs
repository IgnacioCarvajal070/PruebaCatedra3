using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Data;
using PruebaCatedra3.src.Models;
using PruebaCatedra3.src.Repository.Interfaces;

namespace PruebaCatedra3.src.Repository.Implements
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;
        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User?> GetUser(string email)
        {
            return await _context.Users.FindAsync(email);
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> verifyUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}