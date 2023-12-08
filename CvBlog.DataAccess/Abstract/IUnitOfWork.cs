using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Abstract
{
    // UnitOfWork -> EF,ADO NET,Dapper vb yapıların hepsine UnitOfWork ü implemente edebiliriz
    // UnitOfWork -> 1.Faydası : Ortak Kullanım -> Projemiz içerisinde bulunan tüm repositoryleri tek bi yerden yönetmeyi sağlar.
    // UnitOfWork -> 2.Faydası : Transaction Yapısı -> İşlemlerin tek tek saveChanges olması yerine işlemlerden birinde hata oldu mu diğerlerini de geri alır. yani hepsi için savechanges işlemi 1 kere yapılır.

    // UnitOfWork class ı async lerden olustugu ıcın IDisposable ile gelen void dispose metodu yerine c# 8.0 yenı ozellıgı olan IDisposible kullararak DisposeAsync kullandık.
    // IAsyncDisposable => Context imizi dispose ediyor olucaz yani GarbageCollector(Çöp toplayıcıya) yardım ediyoruz.
    public interface IUnitOfWork : IAsyncDisposable
    {
        // Get ile erişebilicez. -> unitOfWork.Articles...
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        ICompetencyLevelRepository CompetencyLevels { get; }
        ICustomerRepository Customers { get; }
        ICvRepository Cvs { get; }
        IEducationRepository Educations { get; }
        IExperienceRepository Experiences { get; }
        IMyLanguageRepository MyLanguages { get; }
        IPortfolioRepository Portfolios { get; }
        IPortfolioSkillRepository PortfolioSkills { get; }
        IRoleRepository Roles { get; }
        IServiceRepository Services { get; }
        ISkillRepository Skills { get; }
        ISocialMediaRepository SocialMedias { get; }
        IUserRepository Users { get; } 

        // UnitOfWork -> 2.Faydası : Transaction Yapısı - Örnek
        // _unitOfWork.Categories.AddAsync(category);
        // _unitOfWork.Users.AddAsync(user);
        // _unitOfWork.SaveAsync();
        // örneğin category eklendikten sonra user eklenirken hata aldığımızı varsayalım böylece unitOfWork'ün transaction yapısı sayesinde kategori de eklenmeyecektir. Böylece eksik/fazla veriden kurtulmuş olucaz.
        Task<int> SaveAsync();
    }
}
