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
    public interface ISkillService
    {
        Task<IDataResult<SkillDto>> GetAsync(int skillId); 
        Task<IDataResult<SkillListDto>> GetAllAsync(); 
        Task<IDataResult<SkillListDto>> GetAllByNonDeleteAsync(); 
        Task<IDataResult<SkillListDto>> GetAllByNonDeleteAndActiveAsync();
        Task<IResult> AddAsync(SkillAddDto skillAddDto, string createdByName);
        Task<IResult> UpdateAsync(SkillUpdateDto skillUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int skillId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int skillId);
    }
}
