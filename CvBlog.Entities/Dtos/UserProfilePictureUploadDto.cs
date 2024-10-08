using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class UserProfilePictureUploadDto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        public IFormFile PictureFile { get; set; }
        [Required]
        public string Picture { get; set; }
    }
}
