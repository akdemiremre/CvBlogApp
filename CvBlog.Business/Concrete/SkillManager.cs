using AutoMapper;
using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Services.Utilities;
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
        public async Task<IResult> AddAsync(SkillAddDto skillAddDto, string createdByName)
        {
            try
            {
                var skill = _mapper.Map<Skill>(skillAddDto);
                skill.CreatedByName = createdByName;
                skill.ModifiedByName = createdByName;
                await _unitOfWork.Skills.AddAsync(skill).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success,Messages.Skill.Add(true,skill.Name));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.Skill.Error("Yetenek ekleme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IResult> DeleteAsync(int skillId, string modifiedByName)
        {
            try
            {
                var reseult = await _unitOfWork.Skills.AnyAsync(x => x.Id == skillId);
                if (reseult)
                {
                    var skill = await _unitOfWork.Skills.GetAsync(x => x.Id == skillId);
                    skill.IsDeleted = true;
                    skill.ModifiedByName = modifiedByName;
                    await _unitOfWork.Skills.UpdateAsync(skill).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.Skill.Delete(true,skill.Name));
                }
                return new Result(ResultStatus.Error, Messages.Skill.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success, Messages.Skill.Error("Yetenek silme işlemi", Ex.Message.ToString()));
            }
        }

        public async Task<IDataResult<SkillDto>> GetAsync(int skillId)
        {
            try
            {
                var skill = await _unitOfWork.Skills.GetAsync(x => x.Id == skillId);
                if (skill != null)
                {
                    return new DataResult<SkillDto>(ResultStatus.Success, new SkillDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Skill = skill
                    });
                }
                return new DataResult<SkillDto>(ResultStatus.Error, Messages.Skill.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<SkillDto>(ResultStatus.Error, Messages.Skill.Error("Yetenek çekme işlemi", Ex.Message.ToString()),null);
            }
        }

        public async Task<IDataResult<SkillListDto>> GetAllAsync()
        {
            try
            {
                var skills = await _unitOfWork.Skills.GetAllAsync();
                if (skills.Count > -1)
                {
                    return new DataResult<SkillListDto>(ResultStatus.Success, new SkillListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Skills = skills
                    });
                }
                return new DataResult<SkillListDto>(ResultStatus.Error, Messages.Skill.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<SkillListDto>(ResultStatus.Error, Messages.Skill.Error("Yetenek kayıtlarını çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<SkillListDto>> GetAllByNonDeleteAsync()
        {
            try
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
                return new DataResult<SkillListDto>(ResultStatus.Error, Messages.Skill.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<SkillListDto>(ResultStatus.Error, Messages.Skill.Error("Yetenek kayıtlarını çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<SkillListDto>> GetAllByNonDeleteAndActiveAsync()
        {
            try
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
                return new DataResult<SkillListDto>(ResultStatus.Error, Messages.Skill.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<SkillListDto>(ResultStatus.Error, Messages.Skill.Error("Yetenek kayıtlarını çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> HardDeleteAsync(int skillId)
        {
            try
            {
                var result = await _unitOfWork.Skills.AnyAsync(x => x.Id == skillId);
                if (result)
                {
                    var skill = await _unitOfWork.Skills.GetAsync(x => x.Id == skillId);
                    await _unitOfWork.Skills.DeleteAsync(skill).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success,Messages.Skill.HardDelete(true,skill.Name));
                }
                return new Result(ResultStatus.Error, "Böyle bir yetenek bulunamadı.", null);
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Skill.Error("Yetenek kaydını kalıcı olarak silme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> UpdateAsync(SkillUpdateDto skillUpdateDto, string modifiedByName)
        {
            try
            {
                var skill = _mapper.Map<Skill>(skillUpdateDto);
                skill.ModifiedByName = modifiedByName;
                await _unitOfWork.Skills.UpdateAsync(skill).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.Skill.Update(true, skill.Name));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Skill.Error("Yetenek kaydını güncelleme işlemi", Ex.Message.ToString()), null);
            }
        }
    }
}
