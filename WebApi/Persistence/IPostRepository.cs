using System.Collections.Generic;
using WebApi.Models.JoinModels;

namespace WebApi.Persistence
{
    public interface IPostRepository
    {
        PostWithUserDetails GetPost(int id);
        IEnumerable<PostWithUserDetails> GetPosts();
        PostWithUserDetails GetPostByUser(string userId, int id);
        IEnumerable<PostWithUserDetails> GetPostsByUser(string userId);
    }
}
