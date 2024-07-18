using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/oturum")]
    public class AuthController : Controller
    {
        [Route("giris-yap")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
