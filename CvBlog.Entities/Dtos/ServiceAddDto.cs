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
    public class ServiceAddDto
    {
        [DisplayName("Servis Adı")]
        public string Name { get; set; }
        [DisplayName("Servis Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        public bool IsActive { get; set; }
    }
}
