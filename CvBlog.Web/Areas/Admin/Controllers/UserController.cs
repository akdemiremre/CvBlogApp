﻿using AutoMapper;
using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Services.Concrete;
using CvBlog.Services.Utilities;
using CvBlog.Shared.Utilities.Exttensions;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;
using CvBlog.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/kullanici")]
    public class UserController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly IWebHostEnvironment _env;
        public UserController(UserManager<User> userManager, IWebHostEnvironment env, IMapper mapper) : base(mapper)
        {
            _userManager = userManager;
            _env = env;
        }

        [Route("liste")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(new UserListDto
            {
                Users = users,
                ResultStatus = ResultStatus.Success
            });
        }
        [Route("liste-yinele")]
        [HttpGet]
        public async Task<IActionResult> ListRefresh()
        {
            var users = await _userManager.Users.ToListAsync();
            return Json(new UserListDto
            {
                Users = users,
                ResultStatus = ResultStatus.Success
            });
        }
        [Route("kullanici-ekleme-formu")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_UserAddModalPartial");
        }
        [Route("kullanici-ekle")]
        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            ModelState.Remove("Picture");
            if (ModelState.IsValid)
            {
                userAddDto.Picture = await ImageUpload(userAddDto.UserName,userAddDto.PictureFile);
                var user = Mapper.Map<User>(userAddDto);
                var result = await _userManager.CreateAsync(user, userAddDto.Password);
                if (result.Succeeded)
                {
                    var userAddAjaxViewModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
                    {
                        UserDto = new UserDto
                        {
                            ResultStatus = ResultStatus.Success,
                            Message = $"{user.UserName} adlı kullanıcı adına sahip kullanıcı başarıyla eklenmiştir.",
                            User = user
                        },
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddModalPartial",userAddDto)
                    });
                    return Json(userAddAjaxViewModel);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        // İlk parametre : Hatanın hangi alan için ekleneceğini belirtilir. -> summary e eklemesini istediğimiz için "" bıraktık.
                        ModelState.AddModelError("", error.Description);
                    }
                    var userAddAjaxErrorViewModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
                    {
                        UserAddDto = userAddDto, // Doldurulmuş alanların ve hataların geri dönemesi için gerekli.
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddModalPartial", userAddDto)
                    });
                    return Json(userAddAjaxErrorViewModel);
                }
            }
            var userAddAjaxModelStateErrorViewModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
            {
                UserAddDto = userAddDto, // Doldurulmuş alanların ve hataların geri dönemesi için gerekli.
                UserAddPartial = await this.RenderViewToStringAsync("_UserAddModalPartial", userAddDto)
            });
            return Json(userAddAjaxModelStateErrorViewModel);
        }
        [Route("kullanici-sil")]
        [HttpPost]
        public async Task<JsonResult> Delete(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                var deletedUser = JsonSerializer.Serialize(new UserDto
                {
                    ResultStatus = ResultStatus.Success,
                    User = user,
                    Message = $"{user.UserName} kullanıcı adlı kayıt başarıyla silinmiştir."
                });
                ImageDelete(user.Picture);
                return Json(deletedUser);
            }
            else
            {
                string errorMessages = string.Empty;
                foreach (var item in result.Errors)
                {
                    errorMessages = $"*{item.Description}\n";
                }
                var deletedUserErrorModel = JsonSerializer.Serialize(new UserDto
                {
                    ResultStatus = ResultStatus.Error,
                    User = user,
                    Message = $"{user.UserName} kullanıcı adlı kayıt silinemedi!\n{errorMessages}"
                });
                return Json(deletedUserErrorModel);
            }
        }
        [Route("kullanici-guncelleme-formu")]
        [HttpGet]
        public async Task<PartialViewResult> Update(int userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
            var userUpdateDto = Mapper.Map<UserUpdateDto>(user);
            return PartialView("_UserUpdateModalPartial", userUpdateDto);
        }
        [Route("kullanici-guncelle")]
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            if (ModelState.IsValid)
            {
                bool isNewPictureUploaded = false;
                var oldUser = await _userManager.FindByIdAsync(userUpdateDto.Id.ToString());
                var oldUserPicture = oldUser.Picture;
                if (userUpdateDto.PictureFile != null)
                {
                    userUpdateDto.Picture = await ImageUpload(userUpdateDto.UserName, userUpdateDto.PictureFile);
                    isNewPictureUploaded = true;
                }
                var updatedUser = Mapper.Map<UserUpdateDto,User>(userUpdateDto, oldUser);
                var result = await _userManager.UpdateAsync(updatedUser);
                if (result.Succeeded)
                {
                    if (isNewPictureUploaded)
                    {
                        ImageDelete(oldUserPicture);
                    }
                    var userUpdateViewModel = JsonSerializer.Serialize(new UserUpdateAjaxViewModel
                    {
                        UserDto = new UserDto
                        {
                            ResultStatus = ResultStatus.Success,
                            Message = $"{updatedUser.UserName} adlı kullanıcı başarıyla güncellenmiştir.",
                            User = updatedUser
                        },
                        UserUpdateDto = userUpdateDto,
                        UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdateModalPartial", userUpdateDto)
                    });
                    return Json(userUpdateViewModel);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    var userUpdateErrorViewModel = JsonSerializer.Serialize(new UserUpdateAjaxViewModel
                    {
                        UserUpdateDto = userUpdateDto,
                        UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdateModalPartial", userUpdateDto)
                    });
                    return Json(userUpdateErrorViewModel);
                }
            }
            else
            {
                var userUpdateModelStateErrorViewModel = JsonSerializer.Serialize(new UserUpdateAjaxViewModel
                {
                    UserUpdateDto = userUpdateDto,
                    UserUpdatePartial = await this.RenderViewToStringAsync("_UserUpdateModalPartial", userUpdateDto)
                });
                return Json(userUpdateModelStateErrorViewModel);
            }
        }
        public async Task<string> ImageUpload(string userName, IFormFile pictureFile)
        {
            string wwwroot = _env.WebRootPath;
            string fileExtension = Path.GetExtension(pictureFile.FileName);
            DateTime dateTime = DateTime.Now;
            string fileName = $"{userName}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
            var path = Path.Combine($"{wwwroot}/img", fileName);
            await using (var stream = new FileStream(path,FileMode.Create))
            {
                await pictureFile.CopyToAsync(stream);
            }
            return fileName;
        }
        public bool ImageDelete(string pictureName)
        {
            string wwwroot = _env.WebRootPath;
            var fileToDelete = Path.Combine($"{wwwroot}/img",pictureName);
            if (System.IO.File.Exists(fileToDelete))
            {
                System.IO.File.Delete(fileToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}