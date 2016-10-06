using System.Collections.Generic;
using WebApi.Models.JoinModels;

namespace WebApi.Persistence
{
    public interface ICommentRepository
    {
        CommentWithUserDetails GetPostComment(int postId, int commentId);
        IEnumerable<CommentWithUserDetails> GetAllPostComments(int postId);
        IEnumerable<CommentWithUserDetails> GetAllUserPostComments(string userId, int postId);
    }
}
