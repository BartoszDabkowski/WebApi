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

        public IEnumerable<CommentWithUserDetails> GetPostComments(int postId)
        {
            var commentWithUserDetails = _context.Comments.Join(_context.Users,
                c => c.UserId,
                u => u.Id,
                (comment, user) => new CommentWithUserDetails
                {
                    Id = comment.Id,
                    PostId = comment.PostId,
                    Body = comment.Body,
                    DateTime = comment.DateTime,
                    Name = user.Name
                });

            return commentWithUserDetails;
        }

        public IEnumerable<Post> GetPostsByUser(string userId)
        {
            return _context.Posts.Where(p => p.UserId == userId).ToList();
        }
    }
}