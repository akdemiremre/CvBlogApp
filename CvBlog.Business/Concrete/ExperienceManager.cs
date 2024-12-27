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
    public class ExperienceManager : IExperienceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ExperienceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(ExperienceAddDto experienceAddDto, string createdByName)
        {
            try
            {
                var experience = _mapper.Map<Experience>(experienceAddDto);
                experience.CreatedByName = createdByName;
                experience.ModifiedByName = createdByName;
                await _unitOfWork.Experiences.AddAsync(experience).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success,Messages.Experience.Add(true));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success,Messages.Experience.Error("Deneyim ekleme işlemi", Ex.Message.ToString()));
            }
        }

        public async Task<IResult> DeleteAsync(int experienceId, string modifiedByName)
        {
            try
            {
                bool result = await _unitOfWork.Experiences.AnyAsync(x => x.Id == experienceId);
                if (result)
                {
                    var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == experienceId);
                    experience.ModifiedByName = modifiedByName;
                    experience.ModifiedDate = DateTime.Now;
                    experience.IsDeleted = true;
                    await _unitOfWork.Experiences.UpdateAsync(experience).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success,Messages.Experience.Delete(true));
                }
                return new Result(ResultStatus.Error, "Böyle bir kayıt bulunamadı.");
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Experience.Error("Deneyim silme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IDataResult<ExperienceDto>> GetAsync(int experienceId)
        {
            try
            {
                var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == experienceId);
                if (experience != null)
                {
                    return new DataResult<ExperienceDto>(ResultStatus.Success, new ExperienceDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Experience = experience
                    });
                }
                return new DataResult<ExperienceDto>(ResultStatus.Error, Messages.Experience.NotFound(false),null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ExperienceDto>(ResultStatus.Error, Messages.Experience.Error("Kayıt çekme işlemi",Ex.Message.ToString()),null);
            }
        }

        public async Task<IDataResult<ExperienceListDto>> GetAllAsync()
        {
            try
            {
                var experiences = await _unitOfWork.Experiences.GetAllAsync();
                if (experiences.Count > -1)
                {
                    return new DataResult<ExperienceListDto>(ResultStatus.Success, new ExperienceListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Experiences = experiences
                    });
                }
                return new DataResult<ExperienceListDto>(ResultStatus.Error,Messages.Experience.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ExperienceListDto>(ResultStatus.Error,Messages.Experience.Error("Kayıtları çekme işlemi",Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<ExperienceListDto>> GetAllByNonDeletedAsync()
        {
            try
            {
                var experiences = await _unitOfWork.Experiences.GetAllAsync(x => !x.IsDeleted);
                if (experiences.Count > -1)
                {
                    return new DataResult<ExperienceListDto>(ResultStatus.Success, new ExperienceListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Experiences = experiences
                    });
                }
                return new DataResult<ExperienceListDto>(ResultStatus.Error, Messages.Experience.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ExperienceListDto>(ResultStatus.Error, Messages.Experience.Error("Kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<ExperienceListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            try
            {
                var experiences = await _unitOfWork.Experiences.GetAllAsync(x => !x.IsDeleted && x.IsActive);
                if (experiences.Count > -1)
                {
                    return new DataResult<ExperienceListDto>(ResultStatus.Success, new ExperienceListDto
                    {
                        ResultStatus = ResultStatus.Success,
                        Experiences = experiences
                    });
                }
                return new DataResult<ExperienceListDto>(ResultStatus.Error, Messages.Experience.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ExperienceListDto>(ResultStatus.Error, Messages.Experience.Error("Kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> HardDeketeAsync(int experienceId)
        {
            try
            {
                bool result = await _unitOfWork.Experiences.AnyAsync(x => x.Id == experienceId);
                if (result)
                {
                    var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == experienceId);
                    await _unitOfWork.Experiences.DeleteAsync(experience).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.Experience.HardDelete(true));
                }
                return new DataResult<ExperienceListDto>(ResultStatus.Error, Messages.Experience.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<ExperienceListDto>(ResultStatus.Error, Messages.Experience.Error("Kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> UpdateAsync(ExperienceUpdateDto experienceUpdateDto, string modifiedByName)
        {
            try
            {
                var experience = _mapper.Map<Experience>(experienceUpdateDto);
                experience.ModifiedByName = modifiedByName;
                await _unitOfWork.Experiences.UpdateAsync(experience).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.Experience.Update(true));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success,Messages.Experience.Error("Deneyim güncelleme işlemi",Ex.Message.ToString()));
            }
        }
    }
}
