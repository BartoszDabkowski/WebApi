using System.Data.Entity;
using WebApi.Models;

namespace WebApi.Persistence
{
    public interface IApplicationDbContext
    {
        IDbSet<ApplicationUser> Users { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Comment> Comments { get; set; }
    }
}
