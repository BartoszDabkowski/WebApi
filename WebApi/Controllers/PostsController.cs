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

            return posts.Select(Mapper.Map<PostWithUserDetails, PostDto>);
        }

        [HttpGet]
        public IEnumerable<CommentDto> GetAllPostComments(int postId)
        {
            var comments = _unitOfWork.Posts.GetAllPostComments(postId);

            return comments.Select(Mapper.Map<CommentWithUserDetails, CommentDto>);
        }

        [HttpGet]
        public IHttpActionResult GetPostComment(int postId, int id)
        {
            var comment = _unitOfWork.Posts.GetPostComment(postId, id);

            return Ok(Mapper.Map<CommentWithUserDetails, CommentDto>(comment));
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPostsByUser(string userId)
        {
            var comments = _unitOfWork.Posts.GetPostsByUser(userId);

            return comments.Select(Mapper.Map<PostWithUserDetails, PostDto>);
        }
    }
}
