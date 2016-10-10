using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Dtos;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public class CommentsV2Controller : BaseApiController
    {
        public CommentsV2Controller(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public IHttpActionResult GetComment(int commentId)
        {
            var comment = UnitOfWork.Comments.GetComment(commentId);

            if (comment == null)
                return NotFound();

            return Ok(DtoFactory.CreateV2(comment));
        }

        [HttpGet]
        public IEnumerable<CommentV2Dto> GetComments(int postId)
        {
            var comments = UnitOfWork.Comments.GetAllPostComments(postId)
                                        .Select(c => DtoFactory.CreateV2(c));
            return comments;
        }

        [HttpGet]
        public IEnumerable<CommentV2Dto> GetCommentsByUser(string userId, int postId)
        {
            var comments = UnitOfWork.Comments.GetAllUserPostComments(userId, postId)
                                        .Select(c => DtoFactory.CreateV2(c));
            return comments;
        }
    }
}
