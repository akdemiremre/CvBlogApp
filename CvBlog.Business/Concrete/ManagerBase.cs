using AutoMapper;
using CvBlog.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Concrete
{
    public class ManagerBase
    {
        protected IUnitOfWork UnitOfWork { get; } // Pretected olduğu için büyük harfle başladık.
        protected IMapper Mapper { get; }
        public ManagerBase(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
    }
}
