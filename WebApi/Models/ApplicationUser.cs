using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Website { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ApplicationUser()
        {
            Posts = new Collection<Post>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}