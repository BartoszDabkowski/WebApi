using System.Collections.Generic;
using WebApi.Models.Entities;

namespace WebApi.Persistence
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetUsers();
        ApplicationUser GetUser(string id);
    }
}
