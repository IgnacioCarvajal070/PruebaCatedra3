using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaCatedra3.src.CloudinaryImplementation;
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
        private readonly ICloudinaryService _cloudinaryService;
        public PostController(IPostService postService, ICloudinaryService cloudinaryService)
        {
            _postService = postService;
            _cloudinaryService = cloudinaryService;
        }
        [HttpPost]
        public async Task<ActionResult<Post>> CreatePost([FromForm]PostCreateDTO post, IFormFile image)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (userId == null)
                {
                    return Unauthorized();
                }
                if (image == null || image.Length == 0)
                {
                    return BadRequest(new {message = "Imagen requerida"});
                }
                var imageUrl = await _cloudinaryService.UploadImageAsync(image);
                post.ImageUrl = imageUrl;
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