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
        Task<IDataResult<SkillDto>> Get(int skillId); 
        Task<IDataResult<SkillListDto>> GetAll(); 
        Task<IDataResult<SkillListDto>> GetAllByNonDelete(); 
        Task<IDataResult<SkillListDto>> GetAllByNonDeleteAndActive();
        Task<IResult> Add(SkillAddDto skillAddDto, string createdByName);
        Task<IResult> Update(SkillUpdateDto skillUpdateDto, string modifiedByName);
        Task<IResult> Delete(int skillId, string modifiedByName);
        Task<IResult> HardDelete(int skillId);
    }
}
