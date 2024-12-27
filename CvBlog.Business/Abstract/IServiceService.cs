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
        Task<IDataResult<ServiceDto>> GetAsync(int serviceId);
        Task<IDataResult<ServiceListDto>> GetAllAsync();
        Task<IDataResult<ServiceListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<ServiceListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IResult> AddAsync(ServiceAddDto serviceAddDto, string createdByName);
        Task<IResult> UpdateAsync(ServiceUpdateDto serviceUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int serviceId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int serviceId);
    }
}
