using AutoMapper;
using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Abstract;
using CvBlog.Services.Concrete;
using CvBlog.Services.Utilities;
using CvBlog.Shared.Utilities.Exttensions;
using CvBlog.Shared.Utilities.Results.ComplexTypes;
using CvBlog.Shared.Utilities.Results.Concrete;
using CvBlog.Web.Areas.Admin.ViewModels;
using CvBlog.Web.Helpers.Abstract;
using Microsoft.AspNetCore.Authorization;
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
        private readonly SignInManager<User> _signInManager;
        private readonly IImageHelper _imageHelper;

        public UserController(UserManager<User> userManager, IMapper mapper, SignInManager<User> signInManager, IImageHelper imageHelper) : base(mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _imageHelper = imageHelper;
        }
        [Route("giris-yap")]
        [HttpGet]
        public IActionResult Login()
        {
            return View("UserLogin");
        }
        [Route("giris-yap")]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false); // şifre ile giriş yapıcağımızı belirttik.
                    if (result.Succeeded)
                    {
                        // Kullanıcı giriş yaptı.
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-Posta adresiniz veya şifreniz yanlıştır.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-Posta adresiniz veya şifreniz yanlıştır.");
                }
            }
            return View("UserLogin");
        }
        [Route("cikis-yap")]
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [Route("kullanici-ekleme-formu")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_UserAddModalPartial");
        }
        [Authorize(Roles = "Admin")]
        [Route("kullanici-ekle")]
        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            ModelState.Remove("Picture");
            if (ModelState.IsValid)
            {
                try
                {
                    var uploadedImageDtoResult = await _imageHelper.UploadUserImage(userAddDto.UserName, userAddDto.PictureFile);
                    userAddDto.Picture = uploadedImageDtoResult.ResultStatus == ResultStatus.Success ? uploadedImageDtoResult.Data.FullName : "userImages/defaultUser.png";
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
                            UserAddPartial = await this.RenderViewToStringAsync("_UserAddModalPartial", userAddDto)
                        });
                        return Json(userAddAjaxViewModel);
                    }
                    else
                    {
                        _imageHelper.Delete(uploadedImageDtoResult.Data.FullName);
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
                catch (Exception Ex)
                {
                    ModelState.AddModelError("", Ex.Message.ToString());
                    var userAddAjaxExceptionErrorViewModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
                    {
                        UserAddDto = userAddDto,
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddModalPartial", userAddDto)
                    });
                    return Json(userAddAjaxExceptionErrorViewModel);
                }
            }
            var userAddAjaxModelStateErrorViewModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
            {
                UserAddDto = userAddDto, // Doldurulmuş alanların ve hataların geri dönemesi için gerekli.
                UserAddPartial = await this.RenderViewToStringAsync("_UserAddModalPartial", userAddDto)
            });
            return Json(userAddAjaxModelStateErrorViewModel);
        }
        [Authorize(Roles = "Admin")]
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
                _imageHelper.Delete(user.Picture);
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
        [Authorize(Roles = "Admin")]
        [Route("kullanici-guncelleme-formu")]
        [HttpGet]
        public async Task<PartialViewResult> Update(int userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
            var userUpdateDto = Mapper.Map<UserUpdateDto>(user);
            return PartialView("_UserUpdateModalPartial", userUpdateDto);
        }
        [Authorize(Roles = "Admin")]
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
                    var uploadedImageDtoResult = await _imageHelper.UploadUserImage(userUpdateDto.UserName, userUpdateDto.PictureFile);
                    userUpdateDto.Picture = uploadedImageDtoResult.ResultStatus == ResultStatus.Success ? uploadedImageDtoResult.Data.FullName : "userImages/defaultUser.png";
                    isNewPictureUploaded = true;
                }
                var updatedUser = Mapper.Map<UserUpdateDto, User>(userUpdateDto, oldUser);
                var result = await _userManager.UpdateAsync(updatedUser);
                if (result.Succeeded)
                {
                    if (isNewPictureUploaded)
                    {
                        _imageHelper.Delete(oldUserPicture);
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
        [Authorize]
        [Route("profil")]
        [HttpGet]
        public async Task<ViewResult> Profile()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var UuerProfileViewModel = new UserProfileViewModel
            {
                User = user,
                UserProfilePersonalUpdateDto = Mapper.Map<UserProfilePersonalUpdateDto>(user),
                UserProfilePasswordUpdateDto = Mapper.Map<UserProfilePasswordUpdateDto>(user)
            };
            return View(UuerProfileViewModel);
        }
        [Authorize]
        [Route("profil-kisisel-bilgiler-guncelle")]
        [HttpPost]
        public async Task<IActionResult> ProfilePersonalUpdate([FromBody] UserProfilePersonalUpdateDto userProfilePersonalUpdateDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.GetUserAsync(HttpContext.User);
                    var updateDto = Mapper.Map<UserProfilePersonalUpdateDto, User>(userProfilePersonalUpdateDto, user);
                    var result = await _userManager.UpdateAsync(updateDto);
                    if (result.Succeeded)
                    {
                        return Json(new { success = true, message = "Profil başarıyla güncellendi." });
                    }
                    else
                    {
                        string message = string.Empty;
                        foreach (var error in result.Errors.ToList())
                        {
                            message += "<br/>* " + error;
                        }
                        return Json(new { success = false, message = message });
                    }
                }
                catch (Exception Ex)
                {
                    return Json(new { success = false, message = Ex.Message.ToString() });
                }
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                string message = string.Empty;
                foreach (var error in errors)
                {
                    message += "<br/>* " + error;
                }
                //IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return Json(new { success = false, message = message });
            }
        }
        [Authorize]
        [Route("profil-sifre-guncelle")]
        [HttpPost]
        public async Task<IActionResult> ProfilePasswordUpdate([FromBody] UserProfilePasswordUpdateDto userProfilePasswordUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var isVerified = await _userManager.CheckPasswordAsync(user, userProfilePasswordUpdateDto.Password);
                if (isVerified)
                {
                    var result = await _userManager.ChangePasswordAsync(user, userProfilePasswordUpdateDto.Password, userProfilePasswordUpdateDto.NewPassword);
                    if (result.Succeeded)
                    {
                        await _userManager.UpdateSecurityStampAsync(user);// userın güvenirliklik değeri
                        await _signInManager.SignOutAsync(); // user a çıkış yaptırıldı.
                        // giriş yaptırıldı =>>
                        // true => remember me kısmı...
                        // false => kullanıcı kilitleme kısmı
                        await _signInManager.PasswordSignInAsync(user, userProfilePasswordUpdateDto.NewPassword, true, false);
                        return Json(new { success = true, message = "Şifre başarıyla güncellendi." });
                    }
                    else
                    {
                        string message = string.Empty;
                        foreach (var error in result.Errors)
                        {
                            message += "<br/>* " + error.Code + "(" + error.Description + ")";
                        }
                        return Json(new { success = false, message = message });
                    }
                }
                else
                {
                    return Json(new { success = false, message = "Lütfen mevcut şifrenizi kontrol ediniz!" });
                }
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                string message = string.Empty;
                foreach (var error in errors)
                {
                    message += "<br/>* " + error;
                }
                return Json(new { success = false, message = message });
            }
        }
        [Authorize]
        [Route("profil-fotografi-guncelle")]
        [HttpPost]
        public async Task<IActionResult> ProfilePictureUpdate(IFormFile file)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
            long maxFileSize = 1 * 1024 * 1024;
            if (file == null)
            {
                return Json(new { success = false, message = "Lütfen fotoğraf seçiniz!" });
            }
            var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (string.IsNullOrEmpty(ext) || !allowedExtensions.Contains(ext))
            {
                return Json(new { success = false, message = "Geçersiz dosya uzantısı. Sadece .jpg, .jpeg, .png, .gif dosyaları kabul edilir." });
            }
            if (file.Length > maxFileSize)
            {
                return Json(new { success = false, message = "Dosya boyutu 1MB'ı geçemez." });
            }
            var uploadUserImage = await _imageHelper.UploadUserImage(user.UserName, file);
            if (uploadUserImage.ResultStatus == ResultStatus.Success)
            {
                var oldPictureName = user.Picture;
                user.Picture = uploadUserImage.Data.FullName;
                var updateAsyncResult = await _userManager.UpdateAsync(user);
                if (updateAsyncResult.Succeeded)
                {
                    if (oldPictureName != "userImages/defaultUser.png")
                    {
                        var deletedImageResult = _imageHelper.Delete(user.Picture);
                    }
                   return Json(new { success = true, message = uploadUserImage.Message, src = "/img/"+user.Picture });
                }
                else
                {
                    return Json(new { success = false, message = "Kayıt güncelleme işlemi yapılamadı." });
                }
            }
            else
            {
                return Json(new { success = false, message = uploadUserImage.Message });
            }
        }
        [Route("yetkisiz-erisim")]
        [HttpGet]
        public ViewResult AccessDenied()
        {
            return View();
        }
    }
}
