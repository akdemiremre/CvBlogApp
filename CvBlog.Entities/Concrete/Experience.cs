using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // İŞ DENEYİMLERİM
    public class Experience : EntityBase,IEntity
    {
        public string Title { get; set; }
        public string Firm { get; set; }
        public string DateRange { get; set; }
        public string Description { get; set; }
    }
}
