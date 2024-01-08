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
        Task<IDataResult<EducationDto>> Get(int educationId);
        Task<IDataResult<EducationListDto>> GetAll();
        Task<IDataResult<EducationListDto>> GetAllByNonDeleted();
        Task<IDataResult<EducationListDto>> GetAlLByNonDeletedAndActive();
        Task<IResult> Add(EducationAddDto educationAddDto, string createdByName);
        Task<IResult> Update(EducationUpdateDto educationUpdateDto, string modifiedByName);
        Task<IResult> Delete(int educationId, string modifiedByName);
        Task<IResult> HardDelete(int educationId);
    }
}
