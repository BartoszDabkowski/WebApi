using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Persistence
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetUsers();
    }
}
