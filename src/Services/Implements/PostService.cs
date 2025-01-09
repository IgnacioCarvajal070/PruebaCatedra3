using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaCatedra3.src.Dtos;
using PruebaCatedra3.src.Models;
using PruebaCatedra3.src.Repository.Interfaces;
using PruebaCatedra3.src.Services.Interfaces;

namespace PruebaCatedra3.src.Services.Implements
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<PostDTO> CreatePost(PostCreateDTO postDTO, string userId)
        {
            var post = new Post
            {
                Title = postDTO.Title,
                ImageUrl = postDTO.ImageUrl,
                date = DateOnly.FromDateTime(DateTime.Now),
                UserId = userId
            };
                var postCreate = await _postRepository.CreatePost(post);
                return new PostDTO
                {
                    Title = postCreate.Title,
                    ImageUrl = postCreate.ImageUrl,
                    date = postCreate.date,
                    UserId = postCreate.UserId
                };
        }

        public async Task<IEnumerable<PostDTO>> GetPosts()
        {
            var posts = await _postRepository.GetPosts();
            return posts.Select(post => new PostDTO
            {
                Title = post.Title,
                ImageUrl = post.ImageUrl,
                date = post.date,
                UserId = post.UserId
            });
        }
    }
}