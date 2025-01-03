using CvBlog.Data.Concrete.EntityFramework.Mappings;
using CvBlog.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Concrete.EntityFramework.Contexts
{
    public class CvBlogAppContext : IdentityDbContext<User,Role,int,UserClaim,UserRole,UserLogin,RoleClaim,UserToken>
    {
        public CvBlogAppContext(DbContextOptions<CvBlogAppContext> options) : base(options)
        {
            
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CompetencyLevel> CompetencyLevels { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Cv> Cvs { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<MyLanguage> MyLanguageS { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioSkill> PortfolioSkills { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // @ -> içerisidndeki stringi tamamen string olarak almasını sağlar
        //    optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CvBlogApp;Trusted_Connection=True;Connect Timeout=120;MultipleActiveResultSets=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new CompetencyLevelMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CvMap());
            modelBuilder.ApplyConfiguration(new EducationMap());
            modelBuilder.ApplyConfiguration(new EducationLevelMap());
            modelBuilder.ApplyConfiguration(new ExperienceMap());
            modelBuilder.ApplyConfiguration(new MyLanguageMap());
            modelBuilder.ApplyConfiguration(new PortfolioMap());
            modelBuilder.ApplyConfiguration(new PortfolioSkillMap());
            modelBuilder.ApplyConfiguration(new RoleClaimMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new ServiceMap());
            modelBuilder.ApplyConfiguration(new SkillMap());
            modelBuilder.ApplyConfiguration(new SocialMediaMap());
            modelBuilder.ApplyConfiguration(new UserClaimMap());
            modelBuilder.ApplyConfiguration(new UserLoginMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserTokenMap());
        }
    }
}
