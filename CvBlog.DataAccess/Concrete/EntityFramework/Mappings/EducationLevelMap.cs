using CvBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Data.Concrete.EntityFramework.Mappings
{
    public class EducationLevelMap : IEntityTypeConfiguration<EducationLevel>
    {
        public void Configure(EntityTypeBuilder<EducationLevel> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd(); // AutoIncreament
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.CreatedByName).IsRequired();
            builder.Property(e => e.CreatedByName).HasMaxLength(50);
            builder.Property(e => e.ModifiedByName).IsRequired();
            builder.Property(e => e.ModifiedByName).HasMaxLength(50);
            builder.Property(e => e.CreatedDate).IsRequired();
            builder.Property(e => e.ModifiedDate).IsRequired();
            builder.Property(e => e.IsActive).IsRequired();
            builder.Property(e => e.IsDeleted).IsRequired();
            builder.Property(e => e.Note).HasMaxLength(500);
            // EducationLevel ve Education arasındaki ilişkiyi belirt
            builder.HasMany(e => e.Educations)    // EducationLevel birden fazla Education'a sahip olabilir
                   .WithOne(e => e.EducationLevel)  // Education her zaman bir EducationLevel'a sahip olmalı
                   .HasForeignKey(e => e.EducationLevelId)
                   .OnDelete(DeleteBehavior.Restrict);  // bir Eğitim Seviyesi (örneğin "Lisans") silinmeye çalışıldığında, eğer bu eğitim seviyesini kullanan bir Eğitim kaydı varsa, silme işlemi engellenir ve hata meydana gelir.
            builder.ToTable("EducationLevels");
        }
    }
}
