using System;
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

        public IEnumerable<Post> GetPosts()
        {
            return _context.Posts.ToList();
        }

        public IEnumerable<Comment> GetPostComments(int postId)
        {
            return _context.Comments.Where(c => c.PostId == postId);
        }

        public IEnumerable<Post> GetPostsByUser(int userId)
        {
            throw new NotImplementedException();
            //return _context.Posts.Where(p => p. == postId);
        }
    }
}