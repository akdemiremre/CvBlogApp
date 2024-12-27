using AutoMapper;
using CvBlog.Services.Abstract;
using CvBlog.Web.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Editor")]
    [Route("admin/panel")]
    public class HomeController : BaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public HomeController(IMapper mapper, ICategoryService categoryService, IUserService userService) : base(mapper)
        {
            _categoryService = categoryService;
            _userService = userService;
        }
        [HttpGet("anasayfa")]
        public async Task<IActionResult> Index()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            dashboardViewModel.CategoryCount = await _categoryService.CountAsync();
            dashboardViewModel.ArticleCount = 0;
            dashboardViewModel.CommentCount = 0;
            dashboardViewModel.UserCount = await _userService.CountAsync();
            return View(dashboardViewModel);
        }
        public async Task<IActionResult> BlankPage()
        {
            return View();
        }
    }
}
