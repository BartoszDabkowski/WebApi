using WebApi.Models;

namespace WebApi.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IApplicationUserRepository Users { get; }
        public IPostRepository Posts { get; }
        public ICommentRepository Comments { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new ApplicationUserRepository(_context);
            Posts = new PostRepostiory(_context);
            Comments = new CommentRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}