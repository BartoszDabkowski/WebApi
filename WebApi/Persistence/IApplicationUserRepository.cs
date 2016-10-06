using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Models.Entities;

namespace WebApi.Persistence
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetUsers();
    }
}
