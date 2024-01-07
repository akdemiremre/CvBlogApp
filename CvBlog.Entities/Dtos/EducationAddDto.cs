using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class EducationAddDto
    {
        [DisplayName("Okul Derecesi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string SchoolDegree { get; set; }
        [DisplayName("Okul Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string SchoolName { get; set; }
        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string DateRange { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Description { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        public bool IsActive { get; set; }
    }
}
