using System.Data.Entity;
using WebApi.Models;

namespace WebApi.Persistence
{
    public interface IApplicationDbContext
    {
        IDbSet<ApplicationUser> Users { get; set; }
    }
}
