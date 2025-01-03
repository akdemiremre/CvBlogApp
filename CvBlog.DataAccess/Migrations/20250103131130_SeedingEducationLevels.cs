using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBlog.Data.Migrations
{
    public partial class SeedingEducationLevels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.EducationLevels (Name,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES ('Lise',GETDATE(),GETDATE(),0,1,'Migration','Migration','Özel Not')");
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.EducationLevels (Name,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES ('Ön Lisans',GETDATE(),GETDATE(),0,1,'Migration','Migration','Özel Not')");
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.EducationLevels (Name,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES ('Lisans',GETDATE(),GETDATE(),0,1,'Migration','Migration','Özel Not')");
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.EducationLevels (Name,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES ('Yüksek Lisans',GETDATE(),GETDATE(),0,1,'Migration','Migration','Özel Not')");
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.EducationLevels (Name,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES ('Doktora',GETDATE(),GETDATE(),0,1,'Migration','Migration','Özel Not')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
