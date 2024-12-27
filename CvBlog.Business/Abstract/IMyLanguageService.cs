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
    public interface IMyLanguageService
    {
        Task<IDataResult<MyLanguageDto>> GetAsync(int myLanguageId);
        Task<IDataResult<MyLanguageListDto>> GetAllAsync();
        Task<IDataResult<MyLanguageListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<MyLanguageListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IResult> AddAsync(MyLanguageAddDto myLanguageAddDto, string createdByName);
        Task<IResult> UpdateAsync(MyLanguageUpdateDto myLanguageUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int myLanguageId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int myLanguageId);
    }
}
