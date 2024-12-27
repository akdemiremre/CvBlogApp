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
    public class MyLanguageManager : IMyLanguageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MyLanguageManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> AddAsync(MyLanguageAddDto myLanguageAddDto, string createdByName)
        {
            try
            {
                var myLanguage = _mapper.Map<MyLanguage>(myLanguageAddDto);
                myLanguage.CreatedByName = createdByName;
                myLanguage.ModifiedByName = createdByName;
                await _unitOfWork.MyLanguages.AddAsync(myLanguage).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success,Messages.MyLanguage.Add(true,myLanguage.Name));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success,Messages.MyLanguage.Error("Dil bilgisi ekleme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IResult> DeleteAsync(int myLanguageId, string modifiedByName)
        {
            try
            {
                bool result = await _unitOfWork.MyLanguages.AnyAsync(x => x.Id == myLanguageId);
                if (result)
                {
                    var myLanguage = await _unitOfWork.MyLanguages.GetAsync(x => x.Id == myLanguageId);
                    myLanguage.IsDeleted = true;
                    myLanguage.ModifiedByName = modifiedByName;
                    myLanguage.ModifiedDate = DateTime.Now;
                    await _unitOfWork.MyLanguages.UpdateAsync(myLanguage).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success, Messages.MyLanguage.Delete(true,myLanguage.Name));
                }
                return new Result(ResultStatus.Error, Messages.MyLanguage.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error,Messages.MyLanguage.Error("Dil bilgisi silme işlemi",Ex.Message.ToString()));
            }
        }

        public async Task<IDataResult<MyLanguageDto>> GetAsync(int myLanguageId) 
        {
            try
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
                return new DataResult<MyLanguageDto>(ResultStatus.Error, Messages.MyLanguage.NotFound(false), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<MyLanguageDto>(ResultStatus.Error, Messages.MyLanguage.Error("Dil bilgisi kaydı çekme işlemi", Ex.Message.ToString()),null);
            }
        }

        public async Task<IDataResult<MyLanguageListDto>> GetAllAsync()
        {
            try
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
                return new DataResult<MyLanguageListDto>(ResultStatus.Error, Messages.MyLanguage.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<MyLanguageListDto>(ResultStatus.Error,Messages.MyLanguage.Error("Kayıtları çekme işlemi",Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<MyLanguageListDto>> GetAllByNonDeletedAsync()
        {
            try
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
                return new DataResult<MyLanguageListDto>(ResultStatus.Error, Messages.MyLanguage.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<MyLanguageListDto>(ResultStatus.Error, Messages.MyLanguage.Error("Kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IDataResult<MyLanguageListDto>> GetAllByNonDeletedAndActiveAsync()
        {
            try
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
                return new DataResult<MyLanguageListDto>(ResultStatus.Error, Messages.MyLanguage.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<MyLanguageListDto>(ResultStatus.Error, Messages.MyLanguage.Error("Kayıtları çekme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> HardDeleteAsync(int myLanguageId)
        {
            try
            {
                bool result = await _unitOfWork.MyLanguages.AnyAsync(x => x.Id == myLanguageId);
                if (result)
                {
                    var myLanguage = await _unitOfWork.MyLanguages.GetAsync(x => x.Id == myLanguageId);
                    await _unitOfWork.MyLanguages.DeleteAsync(myLanguage).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                    return new Result(ResultStatus.Success,Messages.MyLanguage.HardDelete(true,myLanguage.Name));
                }
                return new Result(ResultStatus.Error, Messages.MyLanguage.NotFound(false));
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Error, Messages.MyLanguage.Error("Kalıcı olarak kayıt silme işlemi", Ex.Message.ToString()), null);
            }
        }

        public async Task<IResult> UpdateAsync(MyLanguageUpdateDto myLanguageUpdateDto, string modifiedByName)
        {
            try
            {
                var myLanguage = _mapper.Map<MyLanguage>(myLanguageUpdateDto);
                myLanguage.ModifiedByName = modifiedByName;
                myLanguage.ModifiedDate = DateTime.Now;
                await _unitOfWork.MyLanguages.UpdateAsync(myLanguage).ContinueWith(t => { _unitOfWork.SaveAsync(); });
                return new Result(ResultStatus.Success, $"{myLanguage.Name} dil kaydı başarıyla güncellenmiştir.");
            }
            catch (Exception Ex)
            {
                return new Result(ResultStatus.Success,Messages.MyLanguage.Error("Güncelleme işlemi",Ex.Message.ToString()));
            }
        }
    }
}
