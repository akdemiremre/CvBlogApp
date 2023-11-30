using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.ViewComponents
{
    public class MyResumeViewComponent : ViewComponent
    {
        public MyResumeViewComponent()
        {
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
