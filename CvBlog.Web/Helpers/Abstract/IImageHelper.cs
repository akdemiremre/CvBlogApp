using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Results.Abstract;

namespace CvBlog.Web.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<ImageUploadedDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages");
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
