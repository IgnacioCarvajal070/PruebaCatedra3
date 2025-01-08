using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Models;

namespace PruebaCatedra3.src.Repository.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPost(int id);
        Task<Post> CreatePost(Post post);
        Task<bool> verifyPost(int id);
    }
}