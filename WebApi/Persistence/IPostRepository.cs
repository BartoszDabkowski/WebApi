using System.Collections.Generic;
using WebApi.Models;
using WebApi.Models.Entities;
using WebApi.Models.JoinModels;

namespace WebApi.Persistence
{
    public interface IPostRepository
    {
        Post GetPost(int postId);
        IEnumerable<PostWithUserDetails> GetPosts();
        IEnumerable<CommentWithUserDetails> GetAllPostComments(int postId);
        CommentWithUserDetails GetPostComment(int postId, int id);
        IEnumerable<PostWithUserDetails> GetPostsByUser(string userId);
    }
}
