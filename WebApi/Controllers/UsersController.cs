using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApi.Dtos;
using WebApi.Persistence;

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
            throw new NotImplementedException();
            //return _unitOfWork.Users.GetUsers();
        }
    }
}
