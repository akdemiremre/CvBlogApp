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
    public class MyLanguageManager : IMyLanguageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MyLanguageManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(MyLanguageAddDto myLanguageAddDto, string createdByName)
        {
            var myLanguage = _mapper.Map<MyLanguage>(myLanguageAddDto);
            myLanguage.CreatedByName = createdByName;
            myLanguage.ModifiedByName = createdByName;
            await _unitOfWork.MyLanguages.AddAsync(myLanguage).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{myLanguage.Name} dili başarıyla kaydedilmiştir.");
        }

        public async Task<IResult> Delete(int myLanguageId, string modifiedByName)
        {
            bool result = await _unitOfWork.MyLanguages.AnyAsync(x => x.Id == myLanguageId);
            if (result)
            {
                var myLanguage = await _unitOfWork.MyLanguages.GetAsync(x => x.Id == myLanguageId);
                myLanguage.IsDeleted = true;
                myLanguage.ModifiedByName = modifiedByName;
                myLanguage.ModifiedDate = DateTime.Now;
                await _unitOfWork.MyLanguages.UpdateAsync(myLanguage).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{myLanguage.Name} dil kaydı başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kayıt bulunamadı.");
        }

        public async Task<IDataResult<MyLanguageDto>> Get(int myLanguageId)
        {
            var myLanguage = await _unitOfWork.MyLanguages.GetAsync(x => x.Id == myLanguageId);
            if (myLanguage != null)
            {
                return new DataResult<MyLanguageDto>(ResultStatus.Success, new MyLanguageDto
                {
                    ResultStatus = ResultStatus.Success,
                    MyLanguage = myLanguage
                });
            }
            return new DataResult<MyLanguageDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<MyLanguageListDto>> GetAll()
        {
            var myLanguages = await _unitOfWork.MyLanguages.GetAllAsync();
            if (myLanguages.Count > -1)
            {
                return new DataResult<MyLanguageListDto>(ResultStatus.Success, new MyLanguageListDto
                {
                    ResultStatus = ResultStatus.Success,
                    MyLanguages = myLanguages
                });
            }
            return new DataResult<MyLanguageListDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<MyLanguageListDto>> GetAllByNonDeleted()
        {
            var myLanguages = await _unitOfWork.MyLanguages.GetAllAsync(x => !x.IsDeleted);
            if (myLanguages.Count > -1)
            {
                return new DataResult<MyLanguageListDto>(ResultStatus.Success, new MyLanguageListDto
                {
                    ResultStatus = ResultStatus.Success,
                    MyLanguages = myLanguages
                });
            }
            return new DataResult<MyLanguageListDto>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<MyLanguageListDto>> GetAllByNonDeletedAndActive()
        {
            var myLanguages = await _unitOfWork.MyLanguages.GetAllAsync(x => !x.IsDeleted && x.IsActive);
            if (myLanguages.Count > -1)
            {
                return new DataResult<MyLanguageListDto>(ResultStatus.Success, new MyLanguageListDto
                {
                    ResultStatus = ResultStatus.Success,
                    MyLanguages = myLanguages
                });
            }
            return new DataResult<MyLanguageListDto>(ResultStatus.Error, null);
        }

        public async Task<IResult> HardDelete(int myLanguageId)
        {
            bool result = await _unitOfWork.MyLanguages.AnyAsync(x => x.Id == myLanguageId);
            if (result)
            {
                var myLanguage = await _unitOfWork.MyLanguages.GetAsync(x => x.Id == myLanguageId);
                await _unitOfWork.MyLanguages.DeleteAsync(myLanguage).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{myLanguage.Name} dil kaydı başarıyla kalıcı olarak silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kayıt bulunamadı.");
        }

        public async Task<IResult> Update(MyLanguageUpdateDto myLanguageUpdateDto, string modifiedByName)
        {
            var myLanguage = _mapper.Map<MyLanguage>(myLanguageUpdateDto);
            myLanguage.ModifiedByName = modifiedByName;
            myLanguage.ModifiedDate = DateTime.Now;
            await _unitOfWork.MyLanguages.UpdateAsync(myLanguage).ContinueWith(t => { _unitOfWork.SaveAsync(); });
            return new Result(ResultStatus.Success, $"{myLanguage.Name} dil kaydı başarıyla güncellenmiştir.");
        }
    }
}
