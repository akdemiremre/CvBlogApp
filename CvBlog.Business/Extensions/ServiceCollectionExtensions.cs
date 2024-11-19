using CvBlog.Data.Abstract;
using CvBlog.Data.Concrete;
using CvBlog.Data.Concrete.EntityFramework.Contexts;
using CvBlog.Services.Abstract;
using CvBlog.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Extensions
{
    // Extensions sınıf/metotları kullanabilmek için public static tanımladım.
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection,string connectionString)
        {
            // AddDbContext -> özünde bir scope dur.
            // scoped => Yapılan her request'te nesne tekrar oluşur ve bir request içerisinde sadce bir tane nesne kullanılır. Bu yöntem için AddScoped() metodu kullanılır.
            // Transient ve scoped kullanım şekilleri nesne oluşturma zamanları açısından biraz karıştırılabilir.
            // Transient 'te her nesne çağrımında yeni bir instance oluşturulurken, Scoped'da ise request esnasında yeni bir instance oluşur ve o request sonlanana kadar aynı nesne kullanılır.
            // Request bazında statelss nesne kullanılması istenen durumlarda Scoped bağımlılıkları oluşturabiliriz.
            // Kaynak: http://umutluoglu.com/2017/01/asp-net-core-dependency-injection/
            serviceCollection.AddDbContext<CvBlogAppContext>(options => options.UseSqlServer(connectionString)); //DbContext imizi kaydettik.
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>(); // Eğer birisi IUnitOfWork isterse UnitOfWork ver diyoruz.
            serviceCollection.AddScoped<ICategoryService, CategoryManager>(); // Eğer birisi IUnitOfWork isterse UnitOfWork ver diyoruz.
            serviceCollection.AddScoped<IArticleService, ArticleManager>(); // Eğer birisi IUnitOfWork isterse UnitOfWork ver diyoruz.
            return serviceCollection;
        }
    }
}
