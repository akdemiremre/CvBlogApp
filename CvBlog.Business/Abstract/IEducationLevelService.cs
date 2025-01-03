using CvBlog.Entities.Concrete;
using CvBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Abstract
{
    public interface IEducationLevelService
    {
        Task<IDataResult<List<EducationLevel>>> GetAllAsync();
    }
}
