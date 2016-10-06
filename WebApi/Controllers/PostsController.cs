using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Dtos;
using WebApi.Models.JoinModels;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public class PostsController : BaseApiController
    {
        public PostsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPosts()
        {
            var posts = UnitOfWork.Posts.GetPosts();

            return posts.Select(Mapper.Map<PostWithUserDetails, PostDto>);
        }

        [HttpGet]
        public IEnumerable<CommentDto> GetAllPostComments(int postId)
        {
            var comments = UnitOfWork.Posts.GetAllPostComments(postId)
                                        .Select(c => DtoFactory.Create(c));
            return comments;
        }

        [HttpGet]
        public IHttpActionResult GetPostComment(int postId, int id)
        {
            var comment = UnitOfWork.Posts.GetPostComment(postId, id);

            return Ok(DtoFactory.Create(comment));
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPostsByUser(string userId)
        {
            var comments = UnitOfWork.Posts.GetPostsByUser(userId)
                                        .Select(p => DtoFactory.Create(p));
            return comments;
        }
    }
}
