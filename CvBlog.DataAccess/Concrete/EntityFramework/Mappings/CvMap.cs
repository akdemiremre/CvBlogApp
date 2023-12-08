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
    public class CvMap : IEntityTypeConfiguration<Cv>
    {
        public void Configure(EntityTypeBuilder<Cv> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.FirstName).IsRequired();
            builder.Property(c => c.FirstName).HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(50);
            builder.Property(c => c.DateOfBirth).IsRequired();
            builder.Property(c => c.Address).IsRequired();
            builder.Property(c => c.Address).HasMaxLength(100);
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.Phone).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(21);
            builder.Property(c => c.IsFreelance).IsRequired();
            builder.Property(c => c.HeaderImage).IsRequired();
            builder.Property(c => c.HeaderImage).HasMaxLength(250);
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.Description).HasColumnType("NVARCHAR(MAX)");
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Cvs");
        }
    }
}
