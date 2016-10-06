using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Dtos;
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
            var posts = UnitOfWork.Posts.GetPosts()
                                    .Select(p => DtoFactory.Create(p));
            return posts;
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPostsByUser(string userId)
        {
            var comments = UnitOfWork.Posts.GetPostsByUser(userId)
                                        .Select(p => DtoFactory.Create(p));
            return comments;
        }

        [HttpGet]
        public IHttpActionResult GetPostByUser(string userId, int postId)
        {
            var post = UnitOfWork.Posts.GetPostByUser(userId, postId);

            return Ok(DtoFactory.Create(post));
        } 
    }
}
