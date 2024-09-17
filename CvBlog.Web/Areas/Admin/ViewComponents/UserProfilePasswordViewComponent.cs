using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace CvBlog.Web.Areas.Admin.ViewComponents
{
    public class UserProfilePasswordViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public UserProfilePasswordViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public ViewViewComponentResult Invoke(UserProfilePasswordUpdateDto userProfilePasswordUpdateDto)
        {
            return View(userProfilePasswordUpdateDto);
        }
    }
}
