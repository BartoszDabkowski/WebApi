using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Persistence
{
    public interface IPostRepository
    {
        Post GetPost(int postId);
        IEnumerable<PostWithUserDetails> GetPosts();
        IEnumerable<Comment> GetPostComments(int postId);
        IEnumerable<Post> GetPostsByUser(string userId);
    }
}
