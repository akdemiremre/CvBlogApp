using CvBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Concrete.EntityFramework.Mappings
{
    public class PortfolioSkillMap : IEntityTypeConfiguration<PortfolioSkill>
    {
        public void Configure(EntityTypeBuilder<PortfolioSkill> builder)
        {
            builder.HasKey(ps => ps.Id);
            builder.Property(ps => ps.Id).ValueGeneratedOnAdd();
            builder.Property(ps => ps.PortfolioId).IsRequired();
            builder.Property(ps => ps.SkillId).IsRequired();
            builder.HasOne<Portfolio>(ps => ps.Portfolio).WithMany(p => p.PortfolioSkills).HasForeignKey(ps => ps.PortfolioId);
            builder.HasOne<Skill>(ps => ps.Skill).WithMany(p => p.SkillPortfolios).HasForeignKey(ps => ps.SkillId);
        }
    }
}
