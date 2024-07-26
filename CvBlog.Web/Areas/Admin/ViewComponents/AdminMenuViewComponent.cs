using CvBlog.Entities.Concrete;
using CvBlog.Services.Concrete;
using CvBlog.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace CvBlog.Web.Areas.Admin.ViewComponents
{
	public class AdminMenuViewComponent : ViewComponent
	{
		private readonly UserManager<User> _userManager;
		public AdminMenuViewComponent(UserManager<User> userManager)
		{
            _userManager = userManager;
		}
		public ViewViewComponentResult Invoke()
		{
			// login olan kullanıcıyı HttpContext.User ile aldık.
			// ViewComponent -> asenkron bir işlem yapmaya izin vermediği için .Result kullandık.
			var user = _userManager.GetUserAsync(HttpContext.User).Result; 
			var roles = _userManager.GetRolesAsync(user).Result;
			return View(new UserWithRolesViewModel
			{
				User = user,
				Roles = roles
			});
		}
	}
}
