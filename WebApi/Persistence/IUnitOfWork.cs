using System;

namespace WebApi.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUserRepository Users { get; }
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }

        int Complete();
    }
}
