using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    // DTO = Data Transfer Object
    // Frontend alanı için validasyon sağlar.
    // Fluent API ile backend kontrolünü sağlamıştık. Dto ile frontend kontrolünü sağlamış olduk.
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(70,ErrorMessage ="{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(2,ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [MaxLength(500, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Note { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        public bool IsActive { get; set; }
    }
}
