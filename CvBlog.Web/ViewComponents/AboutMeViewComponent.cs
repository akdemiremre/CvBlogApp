using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.ViewComponents
{
    public class AboutMeViewComponent : ViewComponent
    {
        public AboutMeViewComponent()
        {
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
