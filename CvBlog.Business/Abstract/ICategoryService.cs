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
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IDataResult<CategoryListDto>> GetPagingAllAsync(int pageNumber, int rowCount, string orderColumn, string orderType, string searchValue);
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();
        Task<int> CountAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActiveAsync();
        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto, string createdByName);
        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IResult> UpdateIsActiveAsync(int categoryId, string modifiedByName);
        Task<IResult> DeleteAsync(int categoryId,string modifiedByName);
        Task<IResult> HardDeleteAsync(int categoryId, string modifiedByName);
    }
}
