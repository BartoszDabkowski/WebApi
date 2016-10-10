using System.Data.Entity;
using WebApi.Core.Models.Entities;

namespace WebApi.Core
{
    public interface IApplicationDbContext
    {
        IDbSet<ApplicationUser> Users { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Comment> Comments { get; set; }
    }
}
