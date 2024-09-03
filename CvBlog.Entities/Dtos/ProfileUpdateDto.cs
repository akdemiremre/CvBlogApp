using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class ProfileUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string UserName { get; set; }
        [DisplayName("E-Posta Adresi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(10, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Gsm")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(13, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")] // +905555555555 // 13 characters
        [MinLength(13, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        //[DisplayName("Resim Ekle")]
        //[DataType(DataType.Upload)]
        //[ValidateNever]
        //public IFormFile PictureFile { get; set; }
        //[DisplayName("Resim")]
        //public string Picture { get; set; }
        [DisplayName("Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string FirstName { get; set; }
        [DisplayName("Soyadı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string LastName { get; set; }
        //[DisplayName("Açıklama")]
        //[Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        //[MaxLength(1000, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        //[MinLength(4, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        //public string About { get; set; }
        [DisplayName("Youtube Link")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string YoutubeLink { get; set; }
        [DisplayName("Twitter Link")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string TwitterLink { get; set; }
        [DisplayName("Instagram Link")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string InstagramLink { get; set; }
        [DisplayName("Facebook Link")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string FacebookLink { get; set; }
        [DisplayName("LinkedIn Link")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string LinkedInLink { get; set; }
        [DisplayName("GitHub Link")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string GitHubLink { get; set; }
        [DisplayName("Website Link")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string WebsiteLink { get; set; }
    }
}
