using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaCatedra3.src.Dtos;
using PruebaCatedra3.src.Models;
using PruebaCatedra3.src.Services.Interfaces;

namespace PruebaCatedra3.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpPost]
        public async Task<ActionResult<Post>> CreatePost(PostCreateDTO post)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (userId == null)
                {
                    return Unauthorized();
                }
                var newPost = await _postService.CreatePost(post, userId);
                return Ok(newPost);
            }
            catch (Exception e)
            {
                return BadRequest(new {e.Message});
            }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            try
            {
                var posts = await _postService.GetPosts();
                return Ok(posts);
            }
            catch (Exception e)
            {
                return BadRequest(new {e.Message});
            }
        }
    }
}