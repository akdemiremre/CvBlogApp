using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // YAPTIĞIM İŞLER
    public class Portfolio : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Images { get; set; }
        public DateTime Date { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public ICollection<PortfolioSkill> PortfolioSkills { get; set; }
    }
}
