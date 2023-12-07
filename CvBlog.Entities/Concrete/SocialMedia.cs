using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // SOSYAL MEDYALAR
    public class SocialMedia : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
