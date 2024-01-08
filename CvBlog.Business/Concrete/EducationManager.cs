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
    public class EducationManager : IEducationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EducationManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Add(EducationAddDto educationAddDto, string createdByName)
        {
            var education = _mapper.Map<Education>(educationAddDto);
            education.CreatedByName = createdByName;
            education.ModifiedByName = createdByName;
            await _unitOfWork.Educations.AddAsync(education).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{education.SchoolName} okuluna ait eğitim bilgisi başarıyla kaydedildi.");
        }

        public async Task<IResult> Delete(int educationId, string modifiedByName)
        {
            var result = await _unitOfWork.Educations.AnyAsync(x => x.Id == educationId);
            if (result) 
            {
                var education = await _unitOfWork.Educations.GetAsync(x => x.Id == educationId);
                education.ModifiedByName = modifiedByName;
                education.ModifiedDate = DateTime.Now;
                await _unitOfWork.Educations.UpdateAsync(education).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{education.SchoolName} isimli okula ait kayıt başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kayıt bulunamadı.");
        }

        public async Task<IDataResult<EducationListDto>> GetAll()
        {
            var educations = await _unitOfWork.Educations.GetAllAsync();
            if (educations.Count > -1)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                {
                    Educations = educations,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Herhangi bir eğitim kaydı bulunamadı", null);
        }

        public async Task<IDataResult<EducationListDto>> GetAllByNonDeleted()
        {
            var educations = await _unitOfWork.Educations.GetAllAsync(x => !x.IsDeleted);
            if (educations.Count > -1)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                {
                    Educations = educations,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Herhangi bir eğitim kaydı bulunamadı", null);
        }

        public async Task<IDataResult<EducationListDto>> GetAlLByNonDeletedAndActive()
        {
            var educations = await _unitOfWork.Educations.GetAllAsync(x => !x.IsDeleted && x.IsActive);
            if (educations.Count > -1)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                {
                    Educations = educations,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Herhangi bir eğitim kaydı bulunamadı", null);
        }

        public async Task<IDataResult<EducationDto>> Get(int educationId)
        {
            var education = await _unitOfWork.Educations.GetAsync(x => x.Id == educationId);
            if (education != null)
            {
                return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto
                {
                    Education = education,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Herhangi bir eğitim kaydı bulunamadı", null);
        }

        public async Task<IResult> HardDelete(int educationId)
        {
            var result = await _unitOfWork.Educations.AnyAsync(x => x.Id == educationId);
            if (result)
            {
                var education = await _unitOfWork.Educations.GetAsync(x => x.Id == educationId);
                await _unitOfWork.Educations.DeleteAsync(education).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{education.SchoolName} isimli okul kaydı başarıyla kalıcı olarak silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Herhangi bir kayıt bulunamadı.");
        }

        public async Task<IResult> Update(EducationUpdateDto educationUpdateDto, string modifiedByName)
        {
            var education = _mapper.Map<Education>(educationUpdateDto);
            education.ModifiedByName = modifiedByName;
            await _unitOfWork.Educations.UpdateAsync(education).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{education.SchoolName} isimli okula ait kayıt başarıyla güncellenmiştir.");
        }
    }
}
