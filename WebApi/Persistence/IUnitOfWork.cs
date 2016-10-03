using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUserRepository Users { get; }

        int Complete();
    }
}
