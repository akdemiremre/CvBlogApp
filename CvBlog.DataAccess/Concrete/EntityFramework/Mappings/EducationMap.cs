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
    public class EducationMap : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.SchoolDegree).IsRequired();
            builder.Property(e => e.SchoolDegree).HasMaxLength(100);
            builder.Property(e => e.SchoolName).IsRequired();
            builder.Property(e => e.SchoolName).HasMaxLength(100);
            builder.Property(e => e.SchoolName).IsRequired();
            builder.Property(e => e.SchoolName).HasMaxLength(100);
            builder.Property(e => e.DateRange).IsRequired();
            builder.Property(e => e.DateRange).HasMaxLength(50);
            builder.Property(e => e.Description).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(500);
            builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedByName).HasMaxLength(50);
            builder.Property(u => u.ModifiedByName).IsRequired();
            builder.Property(u => u.ModifiedByName).HasMaxLength(50);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.ModifiedDate).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.Note).HasMaxLength(500);
            builder.ToTable("Educations");
        }
    }
}
