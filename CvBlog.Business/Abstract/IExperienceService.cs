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
    public interface IExperienceService
    {
        Task<IDataResult<ExperienceDto>> Get(int experienceId);
        Task<IDataResult<ExperienceListDto>> GetAll();
        Task<IDataResult<ExperienceListDto>> GetAllByNonDeleted();
        Task<IDataResult<ExperienceListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(ExperienceAddDto experienceAddDto, string createdByName);
        Task<IResult> Update(ExperienceUpdateDto experienceUpdateDto, string modifiedByName);
        Task<IResult> Delete(int experienceId, string modifiedByName);
        Task<IResult> HardDekete(int experienceId);
    }
}
