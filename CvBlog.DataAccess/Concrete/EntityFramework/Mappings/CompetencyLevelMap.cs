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
    public class CompetencyLevelMap : IEntityTypeConfiguration<CompetencyLevel>
    {
        public void Configure(EntityTypeBuilder<CompetencyLevel> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("CompetencyLevels");
            /*
             * beginner (başlangıç), elementary (temel), pre-intermediate (ortanın altı), intermediate (orta), upper-intermediate (ortanın üstü), advanced (ileri), proficiency (uzmanlık).
             */
            string[] competencyLevels = { "beginner", "elementary", "pre-intermediate", "intermediate", "upper-intermediate", "advanced", "expert-proficency" };
            for (int i = 0; i < competencyLevels.Count(); i++)
            {
                builder.HasData(new CompetencyLevel
                {
                    Id = i+1,
                    Name = competencyLevels[i],
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "CompetencyLevel("+ competencyLevels[i] + ")",
                });
            }
        }
    }
}
