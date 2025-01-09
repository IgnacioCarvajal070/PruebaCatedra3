using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Dtos;
using PruebaCatedra3.src.Models;

namespace PruebaCatedra3.src.Services.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostDTO>> GetPosts();
        Task<PostDTO> CreatePost(PostCreateDTO postDTO, string userId);
    }
}