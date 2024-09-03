using CvBlog.Entities.Concrete;
using CvBlog.Entities.Dtos;

namespace CvBlog.Web.Areas.Admin.Models
{
    public class UserProfileViewModel
    {
        public User User { get; set; }
        public ProfileUpdateDto ProfileUpdateDto { get; set; }
    }
}
