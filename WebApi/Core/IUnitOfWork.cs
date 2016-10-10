using System;
using WebApi.Core.Repositories;

namespace WebApi.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUserRepository Users { get; }
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }

        int Complete();
    }
}
