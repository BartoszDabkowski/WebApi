using System.Collections.Generic;
using WebApi.Core.Models.JoinModels;

namespace WebApi.Core.Repositories
{
    public interface ICommentRepository
    {
        CommentWithUserDetails GetComment(int commentId);
        CommentWithUserDetails GetPostComment(int postId, int commentId);
        IEnumerable<CommentWithUserDetails> GetAllPostComments(int postId);
        IEnumerable<CommentWithUserDetails> GetAllUserPostComments(string userId, int postId);
    }
}
