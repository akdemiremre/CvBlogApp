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
        Task<IDataResult<MyLanguageDto>> Get(int myLanguageId);
        Task<IDataResult<MyLanguageListDto>> GetAll();
        Task<IDataResult<MyLanguageListDto>> GetAllByNonDeleted();
        Task<IDataResult<MyLanguageListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(MyLanguageAddDto myLanguageAddDto, string createdByName);
        Task<IResult> Update(MyLanguageUpdateDto myLanguageUpdateDto, string modifiedByName);
        Task<IResult> Delete(int myLanguageId, string modifiedByName);
        Task<IResult> HardDelete(int myLanguageId);
    }
}
