using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    public class EducationLevel : EntityBase,IEntity
    {
        public string Name { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
