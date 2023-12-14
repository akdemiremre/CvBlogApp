using CvBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class SkillUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Yetenek Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0) alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(1, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public int Name { get; set; }
        [DisplayName("Yetenek Logo")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0) alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Logo { get; set; }
        [DisplayName("Yeterlilik Seviyesi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int CompetencyLevelId { get; set; }
        public CompetencyLevel CompetencyLevel { get; set; } // NavigationProperty
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int IsActive { get; set; }
        [DisplayName("Silindi Mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir")]
        public int IsDelete { get; set; }
    }
}
