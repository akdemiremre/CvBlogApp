using CvBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Concrete.EntityFramework.Mappings
{
    public class MyLanguageMap : IEntityTypeConfiguration<MyLanguage>
    {
        public void Configure(EntityTypeBuilder<MyLanguage> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.Name).HasMaxLength(50);
            builder.HasOne<CompetencyLevel>(m => m.CompetencyLevel).WithMany().HasForeignKey(m => m.CompetencyLevelId);
            builder.Property(m => m.CreatedByName).IsRequired();
            builder.Property(m => m.CreatedByName).HasMaxLength(50);
            builder.Property(m => m.ModifiedByName).IsRequired();
            builder.Property(m => m.ModifiedByName).HasMaxLength(50);
            builder.Property(m => m.CreatedDate).IsRequired();
            builder.Property(m => m.ModifiedDate).IsRequired();
            builder.Property(m => m.IsActive).IsRequired();
            builder.Property(m => m.IsDeleted).IsRequired();
            builder.Property(m => m.Note).HasMaxLength(500);
            builder.ToTable("MyLanguages");
        }
    }
}
