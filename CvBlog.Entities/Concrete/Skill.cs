using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    // YETENEKLER
    public class Skill : EntityBase, IEntity
    {
        public int Name { get; set; }
        public string Logo { get; set; }
        public int CompetencyLevelId { get; set; }
        public CompetencyLevel CompetencyLevel { get; set; }
        public ICollection<PortfolioSkill> SkillPortfolios { get; set; }

    }
}
