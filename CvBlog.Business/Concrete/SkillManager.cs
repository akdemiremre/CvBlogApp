using AutoMapper;
using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Shared.Utilities.Results.Abstract;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SkillManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(SkillAddDto skillAddDto, string createdByName)
        {
            var skill = _mapper.Map<Skill>(skillAddDto);
            skill.CreatedByName = createdByName;
            skill.ModifiedByName = createdByName;
            await _unitOfWork.Skills.AddAsync(skill).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{skillAddDto.Name} isimli yetenek başarıyla kaydedildi.");
        }

        public async Task<IResult> Delete(int skillId, string modifiedByName)
        {
            var reseult = await _unitOfWork.Skills.AnyAsync(x => x.Id == skillId);
            if (reseult)
            {
                var skill = await _unitOfWork.Skills.GetAsync(x => x.Id == skillId);
                skill.IsDeleted = true;
                skill.ModifiedByName = modifiedByName;
                await _unitOfWork.Skills.UpdateAsync(skill).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{skill.Name} isimli yetenek başarıyla silindi.");
            }
            return new Result(ResultStatus.Error, "Böyle bir yetenek bulunamadı.");
        }

        public async Task<IDataResult<SkillDto>> Get(int skillId)
        {
            var skill = await _unitOfWork.Skills.GetAsync(x => x.Id == skillId);
            if(skill != null)
            {
                return new DataResult<SkillDto>(ResultStatus.Success, new SkillDto
                {
                    ResultStatus = ResultStatus.Success,
                    Skill = skill
                });
            }
            return new DataResult<SkillDto>(ResultStatus.Error, "Böyle bir yetenek bulunamadı.", null);
        }

        public async Task<IDataResult<SkillListDto>> GetAll()
        {
            var skills = await _unitOfWork.Skills.GetAllAsync();
            if(skills.Count > -1)
            {
                return new DataResult<SkillListDto>(ResultStatus.Success, new SkillListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Skills = skills
                });
            }
            return new DataResult<SkillListDto>(ResultStatus.Error, "Hiç bir yetenek bulunamadı!", null);
        }

        public async Task<IDataResult<SkillListDto>> GetAllByNonDelete()
        {
            var skills = await _unitOfWork.Skills.GetAllAsync(x => !x.IsDeleted);
            if (skills.Count > -1)
            {
                return new DataResult<SkillListDto>(ResultStatus.Success, new SkillListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Skills = skills
                });
            }
            return new DataResult<SkillListDto>(ResultStatus.Error, "Hiç bir yetenek bulunamadı!", null);
        }

        public async Task<IDataResult<SkillListDto>> GetAllByNonDeleteAndActive()
        {
            var skills = await _unitOfWork.Skills.GetAllAsync(x => !x.IsDeleted && x.IsActive);
            if (skills.Count > -1)
            {
                return new DataResult<SkillListDto>(ResultStatus.Success, new SkillListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Skills = skills
                });
            }
            return new DataResult<SkillListDto>(ResultStatus.Error, "Hiç bir yetenek bulunamadı.", null);
        }

        public async Task<IResult> HardDelete(int skillId)
        {
            var result = await _unitOfWork.Skills.AnyAsync(x => x.Id == skillId);
            if (result)
            {
                var skill = await _unitOfWork.Skills.GetAsync(x => x.Id == skillId);
                await _unitOfWork.Skills.DeleteAsync(skill).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{skill.Name} adlı yetenek başarıyla kalıcı olarak silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir yetenek bulunamadı.",null);
        }

        public async Task<IResult> Update(SkillUpdateDto skillUpdateDto, string modifiedByName)
        {
            var skill = _mapper.Map<Skill>(skillUpdateDto);
            skill.ModifiedByName = modifiedByName;
            skill.ModifiedDate = DateTime.Now;
            await _unitOfWork.Skills.UpdateAsync(skill).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success,$"{skill.Name} adlı yetenek kaydı başarıyla silinmiştir.");
        }
    }
}
