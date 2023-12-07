using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // BİLDİĞİM DİLLER
    public class MyLanguage : EntityBase, IEntity
    {
        public string Name { get; set; }
        public int CompetencyLevelId { get; set; }
        public CompetencyLevel CompetencyLevel { get; set; }
    }
}
