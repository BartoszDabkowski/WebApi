using System.Collections.Generic;
using System.Linq;
using WebApi.Models;
using WebApi.Models.Entities;

namespace WebApi.Persistence
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
    }
}