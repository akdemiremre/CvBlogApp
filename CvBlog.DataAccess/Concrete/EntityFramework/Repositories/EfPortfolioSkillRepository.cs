using CvBlog.Data.Abstract;
using CvBlog.Entities.Concrete;
using CvBlog.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Concrete.EntityFramework.Repositories
{
    public class EfPortfolioSkillRepository : EfEntityRepositoryBase<PortfolioSkill>, IPortfolioSkillRepository
    {
        public EfPortfolioSkillRepository(DbContext context) : base(context)
        {
        }
    }
}
