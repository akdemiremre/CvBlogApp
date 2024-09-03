using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using CvBlog.Services.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace CvBlog.Web.Areas.Admin.ViewComponents
{
    public class UserProfilePersonalViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;
        public UserProfilePersonalViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public ViewViewComponentResult Invoke(ProfileUpdateDto profileUpdateDto)
        {
            return View(profileUpdateDto);
        }
    }
}
