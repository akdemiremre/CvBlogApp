using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBlog.Data.Migrations
{
    public partial class SeedingEducations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.Educations (EducationLevelId,SchoolName,DateRange,Description,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES (3,'Pendik Türk Telekom Anadolu Teknik Lisesi','2009-2014','Web tasarımı ve progralama dalında eğitim aldım.',GETDATE(),GETDATE(),0,1,'Migration','Migration','Özel Not')");
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.Educations (EducationLevelId,SchoolName,DateRange,Description,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES (5,'Tekirdağ Namuk Kemal Üniversitesi','2009-2014','Çorlu Mühendislik Fakültesi Bilgisayar Mühendisliği bölümünden 3.06 ortalama ile 3.lük derecesinde mezun oldum.',GETDATE(),GETDATE(),0,1,'Migration','Migration','Özel Not')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
