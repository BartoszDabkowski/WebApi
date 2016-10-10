using System.Collections.Generic;
using WebApi.Core.Models.Entities;
using WebApi.Core.Models.JoinModels;

namespace WebApi.Core.Repositories
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
