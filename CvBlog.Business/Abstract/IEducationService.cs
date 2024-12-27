using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;
using CvBlog.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Abstract
{
    public interface IEducationService
    {
        Task<IDataResult<EducationDto>> GetAsync(int educationId);
        Task<IDataResult<EducationListDto>> GetAllAsync();
        Task<IDataResult<EducationListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<EducationListDto>> GetAlLByNonDeletedAndActiveAsync();
        Task<IResult> AddAsync(EducationAddDto educationAddDto, string createdByName);
        Task<IResult> UpdateAsync(EducationUpdateDto educationUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int educationId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int educationId);
    }
}
