using System;
using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Persistence
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public IEnumerable<ApplicationUser> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}