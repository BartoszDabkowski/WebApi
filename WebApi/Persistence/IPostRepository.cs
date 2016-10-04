using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Persistence
{
    public interface IPostRepository
    {
        Post GetPost(int postId);
        IEnumerable<Post> GetPosts();
        IEnumerable<Comment> GetPostComments(int postId);
        IEnumerable<Post> GetPostsByUser(string userId);
    }
}
