using CvBlog.Data.Abstract;
using CvBlog.Data.Concrete.EntityFramework.Contexts;
using CvBlog.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Concrete
{
    // UnitOfWork Class ımızın EF ile bi alakası yoktur diğer araçlar içinde kullanabiliriz. O yüzden Concrete içinde tanımladık. EntityFramework'te tanımlamadık.
    public class UnitOfWork : IUnitOfWork
    {
        #region sonradanOlusturulanlar
        //private readonly DbContext _context;
        // Kendi cotextimizi olusturcaz. sebebi ise bu repositorylerin constructorlarında bizden context istemeleri.
        private readonly CvBlogAppContext _context;

        // implement edilen IArticleRepository,ICategoryRepository.. bunları new() leyemeyeceğimiz için somut hallerini oluşturuyoruz.
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfCompetencyLevelRepository _competencyLevelRepository;
        private EfCustomerRepository _customerRepository;
        private EfCvRepository _cvRepository;
        private EfEducationRepository _educationRepository;
        private EfExperienceRepository _experienceRepository;
        private EfMyLanguageRepository _myLanguageRepository;
        private EfPortfolioRepository _portfolioRepository;
        private EfPortfolioSkillRepository _portfolioSkillRepository;
        private EfRoleRepository _roleRepository;
        private EfServiceRepository _serviceRepository;
        private EfSkillRepository _skillRepository;
        private EfSocialMediaRepository _socialMediaRepository;
        private EfUserRepository _userRepository;
        public UnitOfWork(CvBlogAppContext context)
        {
            _context = context;
        }
        #endregion

        #region implementEdilen
        // _unitOfWork.Articles.AddAsync(article) denildiğinde .Articles kısmında _articleRepository null değilse onu dönüyoruz null ise new() leyip dönüyoruz.
        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public ICompetencyLevelRepository CompetencyLevels => _competencyLevelRepository ?? new EfCompetencyLevelRepository(_context);

        public ICustomerRepository Customers => _customerRepository ?? new EfCustomerRepository(_context);

        public ICvRepository Cvs => _cvRepository ?? new EfCvRepository(_context);

        public IEducationRepository Educations => _educationRepository ?? new EfEducationRepository(_context);

        public IExperienceRepository Experiences => _experienceRepository ?? new EfExperienceRepository(_context);

        public IMyLanguageRepository MyLanguages => _myLanguageRepository ?? new EfMyLanguageRepository(_context);

        public IPortfolioRepository Portfolios => _portfolioRepository ?? new EfPortfolioRepository(_context);

        public IPortfolioSkillRepository PortfolioSkills => _portfolioSkillRepository ?? new EfPortfolioSkillRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public IServiceRepository Services => _serviceRepository ?? new EfServiceRepository(_context);

        public ISkillRepository Skills => _skillRepository ?? new EfSkillRepository(_context);

        public ISocialMediaRepository SocialMedias => _socialMediaRepository ?? new EfSocialMediaRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        #endregion
    }
}
