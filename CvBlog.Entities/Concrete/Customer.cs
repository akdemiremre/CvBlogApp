using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    public class Customer : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
    }
}
