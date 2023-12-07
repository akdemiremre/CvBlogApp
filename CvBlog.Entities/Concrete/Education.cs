using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // EĞİTİM BİLGİLERİM
    public class Education : EntityBase,IEntity
    {
        public string SchoolDegree { get; set; }
        public string SchoolName { get; set; }
        public string DateRange { get; set; }
        public string Description { get; set; }
    }
}
