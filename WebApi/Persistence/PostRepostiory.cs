using System.Collections.Generic;
using System.Linq;
using WebApi.Models;

namespace WebApi.Persistence
{
    public class PostRepostiory : IPostRepository
    {
        private readonly IApplicationDbContext _context;

        public PostRepostiory(IApplicationDbContext context)
        {
            _context = context;
        }
        public Post GetPost(int postId)
        {
           return _context.Posts.SingleOrDefault(p => p.Id == postId);
        }

        public IEnumerable<PostWithUserDetails> GetPosts()
        {
            var postWithUserDetails = _context.Posts.Join(_context.Users,
                p => p.UserId,
                u => u.Id,
                (post, user) => new PostWithUserDetails
                {
                    Id = post.Id,
                    UserId = post.UserId,
                    User = post.User,
                    Title = post.Title,
                    Body = post.Body,
                    DateTime = post.DateTime,
                    Name = user.Name
                });

            return postWithUserDetails;
        }

        public IEnumerable<Comment> GetPostComments(int postId)
        {
            return _context.Comments.Where(c => c.PostId == postId);
        }

        public IEnumerable<Post> GetPostsByUser(string userId)
        {
            return _context.Posts.Where(p => p.UserId == userId).ToList();
        }
    }
}