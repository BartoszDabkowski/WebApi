using System.Collections.Generic;
using System.Linq;
using WebApi.Models;

namespace WebApi.Persistence
{
    public class PostRepostiory : IPostRepository
    {
        private readonly IApplicationDbContext _context;
        private readonly ModelFactory _modelFactory;

        public PostRepostiory(IApplicationDbContext context)
        {
            _context = context;
            _modelFactory = new ModelFactory();
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
                _modelFactory.CreatePostWithUserDetails());

            return postWithUserDetails;
        }

        public IEnumerable<CommentWithUserDetails> GetAllPostComments(int postId)
        {
            var commentsWithUserDetails = _context.Comments.Join(_context.Users,
                c => c.UserId,
                u => u.Id,
                _modelFactory.CreateCommentWithUserDetails());

            return commentsWithUserDetails;
        }

        public CommentWithUserDetails GetPostComment(int postId, int id)
        {
            var commentWithUserDetails = _context.Comments.Join(_context.Users,
                    c => c.UserId,
                    u => u.Id,
                    _modelFactory.CreateCommentWithUserDetails())
                .SingleOrDefault(c => c.Id == id);

            return commentWithUserDetails;
        }

        public IEnumerable<PostWithUserDetails> GetPostsByUser(string userId)
        {
            var postWithUserDetails = _context.Posts
                .Where(u => u.UserId == userId)
                .Join(_context.Users,
                p => p.UserId,
                u => u.Id,
                _modelFactory.CreatePostWithUserDetails());

            return postWithUserDetails;
        }
    }
}