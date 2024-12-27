using CvBlog.Entities.Dtos;

namespace CvBlog.Web.Areas.Admin.ViewModels
{
    public class UserAddAjaxViewModel
    {
        public UserAddDto UserAddDto { get; set; }
        public string UserAddPartial { get; set; }
        public UserDto UserDto { get; set; }
    }
}
