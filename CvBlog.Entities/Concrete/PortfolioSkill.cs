using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Concrete
{
    public class PortfolioSkill : EntityBase,IEntity
    {
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
