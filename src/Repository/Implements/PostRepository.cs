using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PruebaCatedra3.src.Data;
using PruebaCatedra3.src.Models;
using PruebaCatedra3.src.Repository.Interfaces;

namespace PruebaCatedra3.src.Repository.Implements
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDBContext _context;
        public PostRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<bool> CreatePost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Post?> GetPost(string id)
        {
            return await _context.Posts.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<bool> verifyPost(string id)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);
            if (post == null){
                return false;
            }
            return true;
        }
    }
}