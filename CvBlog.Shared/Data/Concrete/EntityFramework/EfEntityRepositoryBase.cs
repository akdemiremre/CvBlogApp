using CvBlog.Shared.Data.Abstract;
using CvBlog.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Shared.Data.Concrete.EntityFramework
{
    // REPOSİTORY BASE
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        
        // Protected kullanma sebebim : EfEntityRepositoryBase dan türeyen diğer sınıflarda DbContext i kendi metotlarımızda implemente edebilmek için DbContext e erişebiliyor olmamız gerekir.
        protected readonly DbContext _context;
        
        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        // _context.Set<TEntity>() : Gelen T nin yani burdaki TEntitynin hangi class olduğunu bulur.
        
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            // await _context.Set<TEntity>().Remove(entity);
            // Remove metodu async çalışmıyor. Yani RemoveAsync metodu yok. Task.Run(() => {işlem}); -> Bu şekilde asnyc task işlemi tanımlamak gerekiyor.
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            // Articles,Category... query için entity i belirledik
            if (predicate!=null)
            {
                // Articles.Where(x=> x.Id=5)
                // Category.Where(x=> x.Id=5)
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                // gelen property leri queyr e include ediyoruz.
                foreach (var includeProperty in includeProperties)
                {
                    // Articles.Where(x=> x.Id=5).Include(includeProperty)
                    // Category.Where(x=> x.Id=5).Include(includeProperty)
                    query = query.Include(includeProperty);
                }
            }
            /*
            return await query.ToListAsync();
            include performans kaybını önlemek için AsNoTracking kullanma sebebimiz : incldue kullandığımızdda SingleOrDefaultAsync() ve ToListAsync() lerde örneğin : makalelerin çekerken kategorileri de gelsin dediğimizde gelen kategoriye ait makalelerde geliyor hatta bu makalelere ait kategorilerde geliyor .... RECVURSİVE yapıda uzayıp gidiyor. Yani birbirine referans eden veriler geliyor... Bu da performans kaybına yol açıyor.
            Her bir get işleminde AsNoTracking() yazmak yerine context e '_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;' bunu yazarak da aynı işlemi sağlayabiliriz.
            */
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                // gelen property leri queyr e include ediyoruz.
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            /*
             return await query.SingleOrDefaultAsync();
             include performans kaybını önlemek için AsNoTracking kullanma sebebimiz : incldue kullandığımızdda SingleOrDefaultAsync() ve ToListAsync() lerde örneğin : makalelerin çekerken kategorileri de gelsin dediğimizde gelen kategoriye ait makalelerde geliyor hatta bu makalelere ait kategorilerde geliyor .... RECVURSİVE yapıda uzayıp gidiyor. Yani birbirine referans eden veriler geliyor... Bu da performans kaybına yol açıyor.
             Her bir get işleminde AsNoTracking() yazmak yerine context e '_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;' bunu yazarak da aynı işlemi sağlayabiliriz.
             */
            return await query.AsNoTracking().SingleOrDefaultAsync();
        }

        public async Task<IList<TEntity>> GetPagingAllAsync(int pageNumber, int rowCount, string orderColumn, string orderType, Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {

            IQueryable<TEntity> query = _context.Set<TEntity>();
            // Articles,Category... query için entity i belirledik
            if (predicate != null)
            {
                // Articles.Where(x=> x.Id=5)
                // Category.Where(x=> x.Id=5)
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                // gelen property leri queyr e include ediyoruz.
                foreach (var includeProperty in includeProperties)
                {
                    // Articles.Where(x=> x.Id=5).Include(includeProperty)
                    // Category.Where(x=> x.Id=5).Include(includeProperty)
                    query = query.Include(includeProperty);
                }
            }

            /*
            return await query.ToListAsync();
            include performans kaybını önlemek için AsNoTracking kullanma sebebimiz : incldue kullandığımızdda SingleOrDefaultAsync() ve ToListAsync() lerde örneğin : makalelerin çekerken kategorileri de gelsin dediğimizde gelen kategoriye ait makalelerde geliyor hatta bu makalelere ait kategorilerde geliyor .... RECVURSİVE yapıda uzayıp gidiyor. Yani birbirine referans eden veriler geliyor... Bu da performans kaybına yol açıyor.
            Her bir get işleminde AsNoTracking() yazmak yerine context e '_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;' bunu yazarak da aynı işlemi sağlayabiliriz.
            */
            int skipCount = 0;
            if (pageNumber > 1)
            {
                skipCount = (pageNumber - 1) * rowCount;
            }
            query = query.OrderBy(orderColumn + " " + orderType).Skip(skipCount).Take(rowCount);
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            //await _context.Set<TEntity>().Update(entity);
            // updateAsync olmadığı için Task.Run ile async çalışacak şekilde yazdık.
            //Task.Run(() => { _context.Set<TEntity>().Update(entity); });
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
            return entity;
        }

    }
}
