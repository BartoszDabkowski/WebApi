using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public class UsersController : ApiController
    {
        private readonly ApplicationDbContext _context;
        private readonly UnitOfWork _unitOfWork;

        public UsersController()
        {
            _context = new ApplicationDbContext();
            _unitOfWork = new UnitOfWork(_context);
        }
    }
}
