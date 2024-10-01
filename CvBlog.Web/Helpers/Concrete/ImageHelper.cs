using CvBlog.Entities.Dtos;
using CvBlog.Shared.Utilities.Exttensions;
using CvBlog.Shared.Utilities.Results.Abstract;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;
using CvBlog.Web.Helpers.Abstract;
using System.IO;

namespace CvBlog.Web.Helpers.Concrete
{
    public class ImageHelper : IImageHelper
    {
        private readonly IWebHostEnvironment _env;
        private readonly string _wwwroot;
        private readonly string imgFolder = "img";
        public ImageHelper(IWebHostEnvironment env)
        {
            _env = env;
            _wwwroot = _env.WebRootPath;
        }

        public async Task<IDataResult<UploadedImageDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages")
        {
            try
            {
                if (!Directory.Exists($"{_wwwroot}/{imgFolder}/{folderName}"))
                {
                    Directory.CreateDirectory($"{_wwwroot}/{imgFolder}/{folderName}");
                }
                string oldFileName = Path.GetFileNameWithoutExtension(pictureFile.FileName);
                string fileExtension = Path.GetExtension(pictureFile.FileName);
                DateTime dateTime = DateTime.Now;
                string newFileName = $"{userName}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
                var path = Path.Combine($"{_wwwroot}/{imgFolder}/{folderName}", newFileName);
                await using (var stream = new FileStream(path, FileMode.Create))
                {
                    await pictureFile.CopyToAsync(stream);
                }
                return new DataResult<UploadedImageDto>(ResultStatus.Success, $"{userName} adlı kullanıcının resmi başarıyla yüklenmiştir.", new UploadedImageDto
                {
                    FullName = $"{folderName}/{newFileName}",
                    OldName = oldFileName,
                    Extension = fileExtension,
                    FolderName = folderName,
                    Path = path,
                    Size = pictureFile.Length
                });
            }
            catch (Exception Ex)
            {
                return new DataResult<UploadedImageDto>(ResultStatus.Error, $"{userName} adlı kullanıcının resmi eklenemedi. Hata : {Ex.Message.ToString()}",null);
            }
        }
    }
}
