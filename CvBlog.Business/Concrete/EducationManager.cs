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
    public class EducationManager : ManagerBase,IEducationService
    {

        public EducationManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork,mapper)
        {

        }

        public async Task<IResult> AddAsync(EducationAddDto educationAddDto, string createdByName)
        {
            try
            {
                var education = Mapper.Map<Education>(educationAddDto);
                education.CreatedByName = createdByName;
                education.ModifiedByName = createdByName;
                await UnitOfWork.Educations.AddAsync(education).ContinueWith(t => { UnitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, Messages.Education.Add(true));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Education.Error("Eğitim bilgisi ekleme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IResult> DeleteAsync(int educationId, string modifiedByName)
        {
            try
            {
                var result = await UnitOfWork.Educations.AnyAsync(x => x.Id == educationId);
                if (result)
                {
                    var education = await UnitOfWork.Educations.GetAsync(x => x.Id == educationId);
                    education.ModifiedByName = modifiedByName;
                    education.ModifiedDate = DateTime.Now;
                    await UnitOfWork.Educations.UpdateAsync(education).ContinueWith(t => { UnitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success,Messages.Education.Delete(true));
                }
                return new Result(ResultStatus.Error, Messages.Education.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Education.Error("Eğitim bilgisi silme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IDataResult<EducationListDto>> GetAllAsync()
        {
            try
            {
                var educations = await UnitOfWork.Educations.GetAllAsync();
                if (educations.Count > -1)
                {
                    return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                    {
                        Educations = educations,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<EducationListDto>(ResultStatus.Error, Messages.Education.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<EducationListDto>(ResultStatus.Error, Messages.Education.Error("Kayıtları listeleme işlemi",Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<EducationListDto>> GetAllByNonDeletedAsync()
        {
            try
            {
                var educations = await UnitOfWork.Educations.GetAllAsync(x => !x.IsDeleted);
                if (educations.Count > -1)
                {
                    return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                    {
                        Educations = educations,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<EducationListDto>(ResultStatus.Error, Messages.Education.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<EducationListDto>(ResultStatus.Error, Messages.Education.Error("Kayıtları listeleme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<EducationListDto>> GetAlLByNonDeletedAndActiveAsync()
        {
            try
            {
                var educations = await UnitOfWork.Educations.GetAllAsync(x => !x.IsDeleted && x.IsActive);
                if (educations.Count > -1)
                {
                    return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                    {
                        Educations = educations,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<EducationListDto>(ResultStatus.Error, Messages.Education.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<EducationListDto>(ResultStatus.Error, Messages.Education.Error("Kayıtları listeleme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<EducationDto>> GetAsync(int educationId)
        {
            try
            {
                var education = await UnitOfWork.Educations.GetAsync(x => x.Id == educationId);
                if (education != null)
                {
                    return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto
                    {
                        Education = education,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<EducationDto>(ResultStatus.Error, Messages.Education.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<EducationDto>(ResultStatus.Error, Messages.Education.Error("Kayıt Çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> HardDeleteAsync(int educationId)
        {
            try
            {
                var result = await UnitOfWork.Educations.AnyAsync(x => x.Id == educationId);
                if (result)
                {
                    var education = await UnitOfWork.Educations.GetAsync(x => x.Id == educationId);
                    await UnitOfWork.Educations.DeleteAsync(education).ContinueWith(t => { UnitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success,Messages.Education.HardDelete(true));
                }
                return new Result(ResultStatus.Error, Messages.Education.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.Education.Error("Kaydı kalıcı olarak silme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IResult> UpdateAsync(EducationUpdateDto educationUpdateDto, string modifiedByName)
        {
            var education = Mapper.Map<Education>(educationUpdateDto);
            education.ModifiedByName = modifiedByName;
            await UnitOfWork.Educations.UpdateAsync(education).ContinueWith(t => { UnitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{education.SchoolName} isimli okula ait kayıt başarıyla güncellenmiştir.");
        }

        public async Task<IDataResult<EducationListDto>> GetPagingAllAsync(int pageNumber, int rowCount, string orderColumn, string orderType, string searchValue)
        {
            try
            {
                var educations = await UnitOfWork.Educations.GetPagingAllAsync(pageNumber, rowCount, orderColumn, orderType, x => !x.IsDeleted && x.SchoolName.Contains(searchValue));
                if (educations.Count > -1)
                {
                    return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                    {
                        Educations = educations,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<EducationListDto>(ResultStatus.Error, Messages.Education.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<EducationListDto>(ResultStatus.Error, Messages.Education.Error("Veri çekme işlemi", Ex.Message.ToString()),null);
            }
        }
        public async Task<int> CountAsync()
        {
            return await UnitOfWork.Educations.CountAsync();
        }
    }
}
