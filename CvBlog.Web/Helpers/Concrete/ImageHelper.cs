﻿using CvBlog.Entities.Dtos;
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

        public IDataResult<ImageDeletedDto> Delete(string pictureName)
        {
            var fileToDelete = Path.Combine($"{_wwwroot}/{imgFolder}", pictureName);
            if (System.IO.File.Exists(fileToDelete))
            {
                var fileInfo = new FileInfo(fileToDelete);
                var imageDeletedDto = new ImageDeletedDto
                {
                    FullName = pictureName,
                    Extension = fileInfo.Extension,
                    Path = fileInfo.FullName,
                    Size = fileInfo.Length
                };
                System.IO.File.Delete(fileToDelete);
                return new DataResult<ImageDeletedDto>(ResultStatus.Success, imageDeletedDto);
            }
            else
            {
                return new DataResult<ImageDeletedDto>(ResultStatus.Error,$"Böyle bir resim bulunamadı!", null);
            }
        }

        public async Task<IDataResult<ImageUploadedDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages")
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
                return new DataResult<ImageUploadedDto>(ResultStatus.Success, $"{userName} adlı kullanıcının resmi başarıyla yüklenmiştir.", new ImageUploadedDto
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
                return new DataResult<ImageUploadedDto>(ResultStatus.Error, $"{userName} adlı kullanıcının resmi eklenemedi. Hata : {Ex.Message.ToString()}",null);
            }
        }
    }
}
