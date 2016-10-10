using System.Collections.Generic;
using System.Linq;
using WebApi.Core;
using WebApi.Core.Models.Entities;
using WebApi.Core.Repositories;

namespace WebApi.Persistence.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly IApplicationDbContext _context;

        public ApplicationUserRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ApplicationUser> GetUsers()
        {
            return _context.Users.ToList();
        }

        public ApplicationUser GetUser(string id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id);
        }
    }
}