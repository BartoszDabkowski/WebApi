using System.Web.Http;
using WebApi.Dtos;
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