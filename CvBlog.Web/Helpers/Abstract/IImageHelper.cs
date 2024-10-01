using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;

namespace CvBlog.Web.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<UploadedImageDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages");
    }
}
