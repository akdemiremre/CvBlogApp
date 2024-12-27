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
        Task<IDataResult<ExperienceDto>> GetAsync(int experienceId);
        Task<IDataResult<ExperienceListDto>> GetAllAsync();
        Task<IDataResult<ExperienceListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<ExperienceListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IResult> AddAsync(ExperienceAddDto experienceAddDto, string createdByName);
        Task<IResult> UpdateAsync(ExperienceUpdateDto experienceUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int experienceId, string modifiedByName);
        Task<IResult> HardDeketeAsync(int experienceId);
    }
}
