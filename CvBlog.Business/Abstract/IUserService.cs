using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Abstract
{
    public interface IUserService 
    {
        Task<int> CountAsync();
        Task<IDataResult<UserListDto>> GetAllAsync();
        Task<IDataResult<UserListDto>> GetPagingAllAsync(int pageNumber, int rowCount, string orderColumn, string orderType, string searchValue);
    }
}
