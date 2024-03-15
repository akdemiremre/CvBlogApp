using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected IMapper Mapper { get; set; }
        public BaseController(IMapper mapper)
        {
            Mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
