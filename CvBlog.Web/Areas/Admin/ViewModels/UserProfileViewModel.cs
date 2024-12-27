using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;

namespace CvBlog.Web.Areas.Admin.ViewModels
{
    public class UserProfileViewModel
    {
        public User User { get; set; }
        public UserProfilePersonalUpdateDto UserProfilePersonalUpdateDto { get; set; }
        public UserProfilePasswordUpdateDto UserProfilePasswordUpdateDto { get; set; }
    }
}
