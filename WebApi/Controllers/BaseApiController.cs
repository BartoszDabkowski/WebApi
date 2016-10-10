using System.Web.Http;
using WebApi.Core;
using WebApi.Core.Dtos;
using WebApi.Core.Repositories;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        private IUnitOfWork _unitOfWork;
        private DtoFactory _dtoFactory;

        protected BaseApiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected IUnitOfWork UnitOfWork
        {
            get
            {
                return _unitOfWork;
            }
        }

        protected DtoFactory DtoFactory
        {
            get
            {
                if (_dtoFactory == null)
                    _dtoFactory = new DtoFactory(Request);

                return _dtoFactory;
            }
        }
    }
}