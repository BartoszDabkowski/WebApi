using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Dtos;
using WebApi.Models;
using WebApi.Models.Entities;
using WebApi.Persistence;

//WeNeverSleep@1850
namespace WebApi.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<UserDto> GetUsers()
        {
            var users = _unitOfWork.Users.GetUsers();

            return users.Select(Mapper.Map<ApplicationUser, UserDto>);
        }
    }
}
