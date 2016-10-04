using System;

namespace WebApi.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUserRepository Users { get; }
        IPostRepository Posts { get; }

        int Complete();
    }
}
