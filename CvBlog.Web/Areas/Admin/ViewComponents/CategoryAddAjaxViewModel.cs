using CvBlog.Entities.Dtos;

namespace CvBlog.Web.Areas.Admin.ViewComponents
{
    public class CategoryAddAjaxViewModel
    {
        public CategoryAddDto CategoryAddDto { get; set; }
        public string CategoryAddPartial { get; set; }
        public CategoryDto CategoryDto { get; set; }
    }
}
