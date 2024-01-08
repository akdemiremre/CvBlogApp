using CvBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class PortfolioAddDto
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage ="{0} alanı boş geçilmemelidir.")]
        [MaxLength(100,ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5,ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(1000, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Description { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Url { get; set; }
        [DisplayName("Görsel")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Images { get; set; }
        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public DateTime Date { get; set; }
        [DisplayName("Hizmet")]
        [Required(ErrorMessage = "{0} alanı seçilmelidir.")]
        public int ServiceId { get; set; }
        public Service Service { get; set; } // NavigationProperty
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı seçilmelidir.")]
        public int IsActive { get; set; }
    }
}
