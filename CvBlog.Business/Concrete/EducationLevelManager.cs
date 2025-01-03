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
    public class EducationLevelManager : IEducationLevelService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EducationLevelManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<List<EducationLevel>>> GetAllAsync()
        {
			try
			{
                var educationLevels = await _unitOfWork.EducationLevels.GetAllAsync();
                if (educationLevels.Count > -1)
                {
                    return new DataResult<List<EducationLevel>>(ResultStatus.Success, educationLevels.ToList());
                }
                return new DataResult<List<EducationLevel>>(ResultStatus.Error, Messages.EducationLevel.NotFound(true), null);
            }
            catch (Exception Ex)
			{
                return new DataResult<List<EducationLevel>>(ResultStatus.Error, Messages.EducationLevel.Error("Kayıtları listeleme işlemi", Ex.Message.ToString()), null);
            }
        }
    }
}
