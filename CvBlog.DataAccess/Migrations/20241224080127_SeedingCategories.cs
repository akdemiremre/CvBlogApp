using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBlog.Data.Migrations
{
    public partial class SeedingCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.Categories (Name,Description,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES ('C#','C# ile İlgili En Güncel Bilgiler',GETDATE(),GETDATE(),0,1,'Migration','Migration','C# Özel Notu')");
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.Categories (Name,Description,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES ('PHP','PHP ile İlgili En Güncel Bilgiler',GETDATE(),GETDATE(),0,1,'Migration','Migration','PHP Özel Notu')");
            migrationBuilder.Sql("INSERT INTO [CvBlogApp].dbo.Categories (Name,Description,CreatedDate,ModifiedDate,IsDeleted,IsActive,CreatedByName,ModifiedByName,Note) VALUES ('JavaScript','JavaScript ile İlgili En Güncel Bilgiler',GETDATE(),GETDATE(),0,1,'Migration','Migration','JavaScript Özel Notu')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
