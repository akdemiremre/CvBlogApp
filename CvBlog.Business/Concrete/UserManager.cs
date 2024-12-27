using AutoMapper;
using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Services.Utilities;
using CvBlog.Shared.Utilities.Results.Abstract;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Concrete
{
    public class UserManager : ManagerBase, IUserService
    {
        private readonly UserManager<User> _userManager;
        public UserManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<int> CountAsync()
        {
            return await UnitOfWork.Users.CountAsync();
        }

        public async Task<IDataResult<UserListDto>> GetAllAsync()
        {
            try
            {
                var users = await UnitOfWork.Users.GetAllAsync(null);
                if (users.Count > -1)
                {
                    return new DataResult<UserListDto>(ResultStatus.Success, new UserListDto
                    {
                        Users = users,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<UserListDto>(ResultStatus.Error, Messages.User.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<UserListDto>(ResultStatus.Error, Messages.User.Error("Kullanıcıları çekme işlemi",Ex.Message.ToString()), null);
            }
        }
        public async Task<IDataResult<UserListDto>> GetPagingAllAsync(int pageNumber, int rowCount, string orderColumn, string orderType, string searchValue)
        {
            try
            {
                //var users = await _unitOfWork.Users.GetAllAsync();
                var users = await UnitOfWork.Users.GetPagingAllAsync(pageNumber, rowCount, orderColumn, orderType, x => x.UserName.Contains(searchValue) || x.Email.Contains(searchValue));
                if (users.Count > -1)
                {
                    return new DataResult<UserListDto>(ResultStatus.Success, new UserListDto
                    {
                        Users = users,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<UserListDto>(ResultStatus.Error, Messages.User.NotFound(true), null);
            }
            catch (Exception Ex)
            {
                return new DataResult<UserListDto>(ResultStatus.Error, Messages.User.Error("Kullanıcıları çekme işlemi", Ex.Message.ToString()), null);
            }
        }
    }
}
