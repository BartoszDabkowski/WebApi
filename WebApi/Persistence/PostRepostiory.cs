using System.Collections.Generic;
using System.Linq;
using WebApi.Models.JoinModels;

namespace WebApi.Persistence
{
    public class PostRepostiory : IPostRepository
    {
        private readonly IApplicationDbContext _context;
        private readonly JoinModelFactory _joinModelFactory;

        public PostRepostiory(IApplicationDbContext context)
        {
            _context = context;
            _joinModelFactory = new JoinModelFactory();
        }

        public PostWithUserDetails GetPost(int id)
        {
            var postWithUserDetails = _context.Posts.Join(_context.Users,
                        p => p.UserId,
                        u => u.Id,
                        _joinModelFactory.CreatePostWithUserDetails())
                    .SingleOrDefault(p => p.Id == id);

            return postWithUserDetails;
        }

        public IEnumerable<PostWithUserDetails> GetPosts()
        {
            var postWithUserDetails = _context.Posts.Join(_context.Users,
                    p => p.UserId,
                    u => u.Id,
                    _joinModelFactory.CreatePostWithUserDetails());

            return postWithUserDetails;
        }

        public PostWithUserDetails GetPostByUser(string userId, int postId)
        {
            var postWithUserDetails = _context.Posts
                .Where(u => u.UserId == userId)
                .Join(_context.Users,
                    p => p.UserId,
                    u => u.Id,
                    _joinModelFactory.CreatePostWithUserDetails())
                .SingleOrDefault(p => p.Id == postId);

            return postWithUserDetails;
        }

        public IEnumerable<PostWithUserDetails> GetPostsByUser(string userId)
        {
            var postWithUserDetails = _context.Posts
                .Where(u => u.UserId == userId)
                .Join(_context.Users,
                    p => p.UserId,
                    u => u.Id,
                    _joinModelFactory.CreatePostWithUserDetails());

            return postWithUserDetails;
        }
    }
}