using System.Collections.Generic;
using System.Linq;
using WebApi.Core;
using WebApi.Core.Models.JoinModels;
using WebApi.Core.Repositories;

namespace WebApi.Persistence.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly IApplicationDbContext _context;
        private readonly JoinModelFactory _joinModelFactory;

        public CommentWithUserDetails GetComment(int commentId)
        {
            var commentWithUserDetails = _context.Comments
                .Join(_context.Users,
                    c => c.UserId,
                    u => u.Id,
                    _joinModelFactory.CreateCommentWithUserDetails())
                .SingleOrDefault(c => c.Id == commentId);

            return commentWithUserDetails;
        }

        public CommentRepository(IApplicationDbContext context)
        {
            _context = context;
            _joinModelFactory = new JoinModelFactory();
        }

        public CommentWithUserDetails GetPostComment(int postId, int commentId)
        {
            var commentWithUserDetails = _context.Comments
                .Where(p => p.PostId == postId)
                .Join(_context.Users,
                    c => c.UserId,
                    u => u.Id,
                    _joinModelFactory.CreateCommentWithUserDetails())
                .SingleOrDefault(c => c.Id == commentId);

            return commentWithUserDetails;
        }

        public IEnumerable<CommentWithUserDetails> GetAllPostComments(int postId)
        {
            var commentsWithUserDetails = _context.Comments
                .Where(p => p.PostId == postId)
                .Join(_context.Users,
                    c => c.UserId,
                    u => u.Id,
                    _joinModelFactory.CreateCommentWithUserDetails());

            return commentsWithUserDetails;
        }

        public IEnumerable<CommentWithUserDetails> GetAllUserPostComments(string userId, int postId)
        {
            var commentsWithUserDetails = _context.Comments.
                Where(u => u.UserId == userId)
                .Join(_context.Users,
                    c => c.UserId,
                    u => u.Id,
                    _joinModelFactory.CreateCommentWithUserDetails())
                    .Where(p => p.PostId == postId);

            return commentsWithUserDetails;
        }
    }
}