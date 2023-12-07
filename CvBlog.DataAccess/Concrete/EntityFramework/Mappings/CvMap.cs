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
            builder.Property(c => c.HeaderImage).IsRequired();
            builder.Property(c => c.HeaderImage).HasMaxLength(250);
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.Description).HasColumnType("NVARCHAR(MAX)");
            builder.HasOne<User>(c => c.User).WithOne(u => u.Cv).HasForeignKey<Cv>(c => c.UserId);
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
