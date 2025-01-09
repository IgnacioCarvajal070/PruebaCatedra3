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
        public async Task<Post> CreatePost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            return await _context.Posts.Include(x => x.User).ToListAsync();
        }
    }
}