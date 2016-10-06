using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Dtos;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public class CommentsController : BaseApiController
    {
        public CommentsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public IEnumerable<CommentDto> GetComments(int postId)
        {
            var comments = UnitOfWork.Comments.GetAllPostComments(postId)
                                        .Select(c => DtoFactory.Create(c));
            return comments;
        }

        [HttpGet]
        public IHttpActionResult GetComment(int postId, int id)
        {
            var comment = UnitOfWork.Comments.GetPostComment(postId, id);

            return Ok(DtoFactory.Create(comment));
        }

        [HttpGet]
        public IEnumerable<CommentDto> GetCommentsByUser(string userId, int postId)
        {
            var comments = UnitOfWork.Comments.GetAllUserPostComments(userId, postId)
                                        .Select(c => DtoFactory.Create(c));
            return comments;
        }

        [HttpGet]
        public IHttpActionResult GetCommentByUser(string userId, int postId, int id)
        {
            var comment = UnitOfWork.Comments.GetAllUserPostComments(userId, postId)
                .SingleOrDefault(c => c.Id == id);

            return Ok(DtoFactory.Create(comment));
        }

        
    }
}
