using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Shared.Entities.Abstract;
using CvBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetPagingAllAsync(int pageNumber, int rowCount, string orderColumn, string orderType, string searchValue);
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<int> CountAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();
        Task<IDataResult<CategoryDto>> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IResult> Delete(int categoryId,string modifiedByName);
        Task<IResult> HardDelete(int categoryId, string modifiedByName);
    }
}
