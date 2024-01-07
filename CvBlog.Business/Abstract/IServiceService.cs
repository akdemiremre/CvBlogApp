using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Abstract
{
    public interface IServiceService
    {
        Task<IDataResult<ServiceDto>> Get(int serviceId);
        Task<IDataResult<ServiceListDto>> GetAll();
        Task<IDataResult<ServiceListDto>> GetAllByNonDeleted();
        Task<IDataResult<ServiceListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(ServiceAddDto serviceAddDto, string createdByName);
        Task<IResult> Update(ServiceUpdateDto serviceUpdateDto, string modifiedByName);
        Task<IResult> Delete(int serviceId, string modifiedByName);
        Task<IResult> HardDelete(int serviceId);
    }
}
