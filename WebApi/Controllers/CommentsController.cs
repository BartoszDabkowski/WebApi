using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Core.Dtos;
using WebApi.Core.Repositories;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public class CommentsController : BaseApiController
    {
        public CommentsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public IHttpActionResult GetComment(int commentId)
        {
            var comment = UnitOfWork.Comments.GetComment(commentId);

            if (comment == null)
                return NotFound();

            return Ok(DtoFactory.Create(comment));
        }

        [HttpGet]
        public IEnumerable<CommentDto> GetComments(int postId)
        {
            var comments = UnitOfWork.Comments.GetAllPostComments(postId)
                                        .Select(c => DtoFactory.Create(c));
            return comments;
        }

        [HttpGet]
        public IEnumerable<CommentDto> GetCommentsByUser(string userId, int postId)
        {
            var comments = UnitOfWork.Comments.GetAllUserPostComments(userId, postId)
                                                .Select(c => DtoFactory.Create(c));

            return comments;
        }

        
    }
}
