using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
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
        Task<DataResult<EducationDto>> Get(int educationId);
        Task<DataResult<EducationListDto>> GetAll();
        Task<DataResult<EducationListDto>> GetAllByNonDeleted();
        Task<DataResult<EducationListDto>> GetAlLByNonDeletedAndActive();
        Task<Result> Add(EducationAddDto educationAddDto, string createdByName);
        Task<Result> Update(EducationUpdateDto educationUpdateDto, string modifiedByName);
        Task<Result> Delete(int educationId, string modifiedByName);
        Task<Result> HardDelete(int educationId);
    }
}
