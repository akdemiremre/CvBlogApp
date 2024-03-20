using CvBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Shared.Data.Abstract
{
    // IRepository

    // Async metotlar kullandım. Async olması zorunlu değil. Sync metotlarda kullanılabilir. 
    // T  => Bu işlemler için class olması gerekiyor, IEntity den türemiş olması gerekiyor ve son olarak new() lenebılır olması gerekiyor.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        // 1.parametre => predicate : where ifadesi
        // PARAMS => 1 den fazla includeProperties verebilmek için params olarak tanımladım.  => (2 ve sonraki parametreler)
        // includeProperties i kullanmaktaki amacım : Örneğin Aritcle için istek attığımda Article a ait Category değerlerinide result a eklemek.
        // includeProperties ta [] dizi kullanmamın sebebi : 1 veya 1 den fazla obje dönebilmek.
        Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T, object>>[] includeProperties);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        // Predicate = null tanımlama sebebimiz : Mesela silinmiş olanları getir veya aktif olanları getir... null verirsek tüm kayıtları alma imkanımmız olacaktır.
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
        Task<IList<T>> GetPagingAllAsync(int pageNumber, int rowCount, string orderColumn, string orderType, Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
    }
}
