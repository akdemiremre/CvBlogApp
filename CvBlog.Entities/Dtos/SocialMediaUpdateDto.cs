using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class SocialMediaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Sosyal Medya Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden fazla olmamalıdır.")]
        [MinLength(1, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır.")]
        public string Name { get; set; }
        [DisplayName("Sosyal Medya Linki")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden fazla olmamalıdır.")]
        [MinLength(10, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır.")]
        public string Url { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int IsActive { get; set; }
        [DisplayName("Silindi Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public int IsDelete { get; set; }
    }
}
