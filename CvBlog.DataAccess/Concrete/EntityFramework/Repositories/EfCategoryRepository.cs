using CvBlog.Data.Abstract;
using CvBlog.Data.Concrete.EntityFramework.Contexts;
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
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {

        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
        private CvBlogAppContext CvBlogAppContext
        {
            /*
            _context.Portfolios veya _context.Categories gelmiyor. Çünkü burdaki dbcontext hangi context oldugunu yani CvBlogAppContext oldugunu bılömıyor.
            bu yüzden private bir field belirleyip contexti eklicez.
             */
            get
            {
                return _context as CvBlogAppContext;
            }
        }
        public async Task<Category> GetById(int categoryId)
        {
            return await CvBlogAppContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        }
    }
}
