﻿using Microsoft.AspNetCore.Mvc;

namespace CvBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> BlankPage()
        {
            return View();
        }
    }
}