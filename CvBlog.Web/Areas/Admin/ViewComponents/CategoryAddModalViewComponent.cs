using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.Areas.Admin.ViewComponents
{
    public class CategoryAddModalViewComponent : ViewComponent
    {
        public CategoryAddModalViewComponent()
        {
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
