using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class ServiceUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Servis Adı")]
        public string Name { get; set; }
        [DisplayName("Servis Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        public bool IsActive { get; set; }
        [DisplayName("Silindi Mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir")]
        public bool IsDeleted { get; set; }
    }
}
