using System.Collections.Generic;
using WebApi.Core.Models.Entities;

namespace WebApi.Core.Repositories
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetUsers();
        ApplicationUser GetUser(string id);
    }
}
