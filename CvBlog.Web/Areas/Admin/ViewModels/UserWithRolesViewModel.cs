using CvBlog.Entities.Concrete;

namespace CvBlog.Web.Areas.Admin.ViewModels
{
    public class UserWithRolesViewModel
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }
    }
}
