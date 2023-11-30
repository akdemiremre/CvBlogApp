using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        public ContactViewComponent()
        {
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
