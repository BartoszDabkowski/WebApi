using System.Collections.Generic;
using WebApi.Models.Entities;
using WebApi.Models.JoinModels;

namespace WebApi.Persistence
{
    public interface IPostRepository
    {
        Post GetPost(int id);
        PostWithUserDetails GetPostWithUserDetails(int id);
        IEnumerable<PostWithUserDetails> GetPostsWithUserDetails();
        PostWithUserDetails GetPostByUser(string userId, int id);
        IEnumerable<PostWithUserDetails> GetPostsByUser(string userId);

        void Add(Post post);
        void Remove(Post post);
    }
}
