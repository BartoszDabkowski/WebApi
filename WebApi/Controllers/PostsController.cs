using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Dtos;
using WebApi.Models;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public class PostsController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPosts()
        {
            var posts = _unitOfWork.Posts.GetPosts();

            return posts.Select(Mapper.Map<Post, PostDto>);
        }
    }
}
