﻿using CvBlog.Entities.Dtos;

namespace CvBlog.Web.Areas.Admin.ViewModels
{
    public class UserUpdateAjaxViewModel
    {
        public UserUpdateDto UserUpdateDto { get; set; }
        public string UserUpdatePartial { get; set; }
        public UserDto UserDto { get; set; }
    }
}
