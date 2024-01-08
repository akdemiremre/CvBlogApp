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
    public class ExperienceManager : IExperienceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ExperienceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Add(ExperienceAddDto experienceAddDto, string createdByName)
        {
            var experience = _mapper.Map<Experience>(experienceAddDto);
            experience.CreatedByName = createdByName;
            experience.ModifiedByName = createdByName;
            await _unitOfWork.Experiences.AddAsync(experience).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{experience.Title} başlıklı deneyim başarıyla eklenmiştir.");
        }

        public async Task<IResult> Delete(int experienceId, string modifiedByName)
        {
            bool result = await _unitOfWork.Experiences.AnyAsync(x => x.Id == experienceId);
            if (result)
            {
                var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == experienceId);
                experience.ModifiedByName = modifiedByName;
                experience.ModifiedDate = DateTime.Now;
                experience.IsDeleted = true;
                await _unitOfWork.Experiences.UpdateAsync(experience).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{experience.Title} başlıklı deneyim başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kayıt bulunamadı.");
        }

        public async Task<IDataResult<ExperienceDto>> Get(int experienceId)
        {
            var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == experienceId);
            if (experience!=null)
            {
                return new DataResult<ExperienceDto>(ResultStatus.Success, new ExperienceDto
                {
                    ResultStatus = ResultStatus.Success,
                    Experience = experience
                });
            }
            return new DataResult<ExperienceDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<ExperienceListDto>> GetAll()
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
            return new DataResult<ExperienceListDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<ExperienceListDto>> GetAllByNonDeleted()
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
            return new DataResult<ExperienceListDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<ExperienceListDto>> GetAllByNonDeletedAndActive()
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
            return new DataResult<ExperienceListDto>(ResultStatus.Error, null);
        }

        public async Task<IResult> HardDekete(int experienceId)
        {
            bool result = await _unitOfWork.Experiences.AnyAsync(x => x.Id == experienceId);
            if (result)
            {
                var experience = await _unitOfWork.Experiences.GetAsync(x => x.Id == experienceId);
                await _unitOfWork.Experiences.DeleteAsync(experience).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{experience.Title} başlıklı deneyim kalıcı olarak başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kayıt bulunamadı.");
        }

        public async Task<IResult> Update(ExperienceUpdateDto experienceUpdateDto, string modifiedByName)
        {
            var experience = _mapper.Map<Experience>(experienceUpdateDto);
            experience.ModifiedByName = modifiedByName;
            await _unitOfWork.Experiences.UpdateAsync(experience).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{experience.Title} başlıklı deneyim başarıyla güncellenmiştir.");
        }
    }
}
