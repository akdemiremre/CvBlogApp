using CvBlog.Entities.Concrete;
using CvBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Abstract
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
    }
}
