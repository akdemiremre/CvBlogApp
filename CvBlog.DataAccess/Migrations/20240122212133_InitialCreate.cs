using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBlog.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetencyLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetencyLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cvs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    IsFreelance = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HeaderImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cvs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CvId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cvs_CvId",
                        column: x => x.CvId,
                        principalTable: "Cvs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolDegree = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateRange = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CvId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Cvs_CvId",
                        column: x => x.CvId,
                        principalTable: "Cvs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Firm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateRange = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CvId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Cvs_CvId",
                        column: x => x.CvId,
                        principalTable: "Cvs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MyLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompetencyLevelId = table.Column<int>(type: "int", nullable: false),
                    CvId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyLanguages_CompetencyLevels_CompetencyLevelId",
                        column: x => x.CompetencyLevelId,
                        principalTable: "CompetencyLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyLanguages_Cvs_CvId",
                        column: x => x.CvId,
                        principalTable: "Cvs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CompetencyLevelId = table.Column<int>(type: "int", nullable: false),
                    CvId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_CompetencyLevels_CompetencyLevelId",
                        column: x => x.CompetencyLevelId,
                        principalTable: "CompetencyLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Skills_Cvs_CvId",
                        column: x => x.CvId,
                        principalTable: "Cvs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CvId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedias_Cvs_CvId",
                        column: x => x.CvId,
                        principalTable: "Cvs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Images = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portfolios_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioSkills_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortfolioSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(201), "Açıklama1", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(202), "Kategori1", "CategoryMap'ten kaydedildi." },
                    { 2, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(212), "Açıklama2", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(213), "Kategori2", "CategoryMap'ten kaydedildi." },
                    { 3, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(217), "Açıklama3", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(218), "Kategori3", "CategoryMap'ten kaydedildi." },
                    { 4, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(221), "Açıklama4", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(221), "Kategori4", "CategoryMap'ten kaydedildi." },
                    { 5, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(224), "Açıklama5", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(225), "Kategori5", "CategoryMap'ten kaydedildi." },
                    { 6, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(230), "Açıklama6", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(230), "Kategori6", "CategoryMap'ten kaydedildi." },
                    { 7, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(233), "Açıklama7", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(234), "Kategori7", "CategoryMap'ten kaydedildi." },
                    { 8, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(237), "Açıklama8", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(237), "Kategori8", "CategoryMap'ten kaydedildi." },
                    { 9, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(240), "Açıklama9", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(241), "Kategori9", "CategoryMap'ten kaydedildi." },
                    { 10, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(246), "Açıklama10", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(246), "Kategori10", "CategoryMap'ten kaydedildi." },
                    { 11, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(249), "Açıklama11", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(250), "Kategori11", "CategoryMap'ten kaydedildi." },
                    { 12, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(253), "Açıklama12", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(254), "Kategori12", "CategoryMap'ten kaydedildi." },
                    { 13, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(257), "Açıklama13", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(258), "Kategori13", "CategoryMap'ten kaydedildi." },
                    { 14, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(261), "Açıklama14", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(261), "Kategori14", "CategoryMap'ten kaydedildi." },
                    { 15, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(265), "Açıklama15", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(265), "Kategori15", "CategoryMap'ten kaydedildi." },
                    { 16, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(268), "Açıklama16", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(269), "Kategori16", "CategoryMap'ten kaydedildi." },
                    { 17, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(272), "Açıklama17", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(273), "Kategori17", "CategoryMap'ten kaydedildi." },
                    { 18, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(277), "Açıklama18", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(277), "Kategori18", "CategoryMap'ten kaydedildi." },
                    { 19, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(281), "Açıklama19", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(281), "Kategori19", "CategoryMap'ten kaydedildi." },
                    { 20, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(284), "Açıklama20", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(285), "Kategori20", "CategoryMap'ten kaydedildi." },
                    { 21, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(288), "Açıklama21", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(289), "Kategori21", "CategoryMap'ten kaydedildi." },
                    { 22, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(296), "Açıklama22", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(296), "Kategori22", "CategoryMap'ten kaydedildi." },
                    { 23, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(300), "Açıklama23", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(300), "Kategori23", "CategoryMap'ten kaydedildi." },
                    { 24, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(304), "Açıklama24", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(304), "Kategori24", "CategoryMap'ten kaydedildi." },
                    { 25, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(307), "Açıklama25", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(308), "Kategori25", "CategoryMap'ten kaydedildi." },
                    { 26, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(311), "Açıklama26", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(312), "Kategori26", "CategoryMap'ten kaydedildi." },
                    { 27, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(315), "Açıklama27", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(315), "Kategori27", "CategoryMap'ten kaydedildi." },
                    { 28, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(319), "Açıklama28", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(319), "Kategori28", "CategoryMap'ten kaydedildi." },
                    { 29, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(322), "Açıklama29", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(323), "Kategori29", "CategoryMap'ten kaydedildi." },
                    { 30, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(326), "Açıklama30", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(327), "Kategori30", "CategoryMap'ten kaydedildi." },
                    { 31, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(330), "Açıklama31", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(330), "Kategori31", "CategoryMap'ten kaydedildi." },
                    { 32, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(334), "Açıklama32", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(334), "Kategori32", "CategoryMap'ten kaydedildi." },
                    { 33, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(338), "Açıklama33", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(338), "Kategori33", "CategoryMap'ten kaydedildi." },
                    { 34, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(342), "Açıklama34", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(343), "Kategori34", "CategoryMap'ten kaydedildi." },
                    { 35, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(346), "Açıklama35", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(347), "Kategori35", "CategoryMap'ten kaydedildi." },
                    { 36, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(350), "Açıklama36", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(350), "Kategori36", "CategoryMap'ten kaydedildi." },
                    { 37, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(354), "Açıklama37", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(354), "Kategori37", "CategoryMap'ten kaydedildi." },
                    { 38, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(358), "Açıklama38", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(358), "Kategori38", "CategoryMap'ten kaydedildi." },
                    { 39, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(362), "Açıklama39", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(362), "Kategori39", "CategoryMap'ten kaydedildi." },
                    { 40, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(365), "Açıklama40", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(366), "Kategori40", "CategoryMap'ten kaydedildi." },
                    { 41, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(369), "Açıklama41", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(370), "Kategori41", "CategoryMap'ten kaydedildi." },
                    { 42, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(373), "Açıklama42", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(373), "Kategori42", "CategoryMap'ten kaydedildi." }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 43, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(404), "Açıklama43", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(404), "Kategori43", "CategoryMap'ten kaydedildi." },
                    { 44, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(408), "Açıklama44", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(408), "Kategori44", "CategoryMap'ten kaydedildi." },
                    { 45, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(412), "Açıklama45", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(412), "Kategori45", "CategoryMap'ten kaydedildi." },
                    { 46, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(416), "Açıklama46", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(416), "Kategori46", "CategoryMap'ten kaydedildi." },
                    { 47, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(419), "Açıklama47", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(420), "Kategori47", "CategoryMap'ten kaydedildi." },
                    { 48, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(423), "Açıklama48", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(424), "Kategori48", "CategoryMap'ten kaydedildi." },
                    { 49, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(427), "Açıklama49", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(427), "Kategori49", "CategoryMap'ten kaydedildi." },
                    { 50, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(431), "Açıklama50", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(431), "Kategori50", "CategoryMap'ten kaydedildi." }
                });

            migrationBuilder.InsertData(
                table: "CompetencyLevels",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3676), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3677), "beginner", "CompetencyLevel(beginner)" },
                    { 2, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3695), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3696), "elementary", "CompetencyLevel(elementary)" },
                    { 3, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3700), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3701), "pre-intermediate", "CompetencyLevel(pre-intermediate)" },
                    { 4, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3704), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3704), "intermediate", "CompetencyLevel(intermediate)" },
                    { 5, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3707), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3708), "upper-intermediate", "CompetencyLevel(upper-intermediate)" },
                    { 6, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3712), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3713), "advanced", "CompetencyLevel(advanced)" },
                    { 7, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3716), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 195, DateTimeKind.Local).AddTicks(3716), "expert-proficency", "CompetencyLevel(expert-proficency)" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 196, DateTimeKind.Local).AddTicks(9075), "Admin Rolü, Tüm Haklara Sahiptir.", true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 196, DateTimeKind.Local).AddTicks(9076), "Admin", "Admin Rolüdür." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "Username" },
                values: new object[] { 1, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 197, DateTimeKind.Local).AddTicks(6479), "Sistemin ilk admin kullanıcısı", "info@emreakdemir.net", "Emre", true, false, "Akdemir", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 197, DateTimeKind.Local).AddTicks(6480), "Admin Kullanıcısı", new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 }, "default.jpg", 1, "info@emreakdemir.net" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8593), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8591), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8594), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale1", 1, 0 },
                    { 2, 2, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8612), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8613), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale2", 1, 0 },
                    { 3, 2, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8617), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8618), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale3", 1, 0 },
                    { 4, 3, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8622), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8621), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8623), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale4", 1, 0 },
                    { 5, 3, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8626), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8627), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale5", 1, 0 },
                    { 6, 4, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8632), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8633), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale6", 1, 0 },
                    { 7, 4, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8636), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8637), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale7", 1, 0 },
                    { 8, 5, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8640), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8642), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale8", 1, 0 },
                    { 9, 5, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8645), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8645), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8646), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale9", 1, 0 },
                    { 10, 6, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8651), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8652), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale10", 1, 0 },
                    { 11, 6, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8655), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8656), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale11", 1, 0 },
                    { 12, 7, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8660), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8659), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8660), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale12", 1, 0 },
                    { 13, 7, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8670), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8671), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale13", 1, 0 },
                    { 14, 8, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8675), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8675), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8676), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale14", 1, 0 },
                    { 15, 8, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8679), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8680), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale15", 1, 0 },
                    { 16, 9, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8683), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8684), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale16", 1, 0 },
                    { 17, 9, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8687), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8688), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale17", 1, 0 },
                    { 18, 10, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8692), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8693), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale18", 1, 0 },
                    { 19, 10, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8697), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8697), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8698), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale19", 1, 0 },
                    { 20, 11, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8701), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8701), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8702), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale20", 1, 0 },
                    { 21, 11, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8705), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8706), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale21", 1, 0 },
                    { 22, 12, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8709), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8711), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale22", 1, 0 },
                    { 23, 12, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8713), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8715), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale23", 1, 0 },
                    { 24, 13, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8718), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8718), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8719), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale24", 1, 0 },
                    { 25, 13, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8722), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8722), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8723), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale25", 1, 0 },
                    { 26, 14, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8726), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8727), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale26", 1, 0 },
                    { 27, 14, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8730), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8731), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale27", 1, 0 },
                    { 28, 15, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8734), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8735), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale28", 1, 0 },
                    { 29, 15, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8738), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8739), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale29", 1, 0 },
                    { 30, 16, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8743), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8744), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale30", 1, 0 },
                    { 31, 16, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8747), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8748), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale31", 1, 0 },
                    { 32, 17, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8751), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8752), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale32", 1, 0 },
                    { 33, 17, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8755), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8755), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8756), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale33", 1, 0 },
                    { 34, 18, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8764), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8765), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale34", 1, 0 },
                    { 35, 18, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8769), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8768), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8769), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale35", 1, 0 },
                    { 36, 19, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8773), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8773), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8774), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale36", 1, 0 },
                    { 37, 19, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8777), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8778), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale37", 1, 0 },
                    { 38, 20, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8781), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8782), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale38", 1, 0 },
                    { 39, 20, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8785), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8786), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale39", 1, 0 },
                    { 40, 21, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8790), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8791), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale40", 1, 0 },
                    { 41, 21, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8794), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8795), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale41", 1, 0 },
                    { 42, 22, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8799), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8798), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8799), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale42", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 43, 22, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8803), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8802), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8803), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale43", 1, 0 },
                    { 44, 23, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8807), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8806), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8807), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale44", 1, 0 },
                    { 45, 23, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8810), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8812), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale45", 1, 0 },
                    { 46, 24, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8815), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8815), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8816), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale46", 1, 0 },
                    { 47, 24, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8819), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8820), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale47", 1, 0 },
                    { 48, 25, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8823), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8824), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale48", 1, 0 },
                    { 49, 25, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8827), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8828), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale49", 1, 0 },
                    { 50, 26, 0, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8832), new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8831), true, false, "InitialCreate", new DateTime(2024, 1, 23, 0, 21, 33, 194, DateTimeKind.Local).AddTicks(8833), "CategoryMap'ten kaydedildi.", "Emre Akdemir", "Emre Akdemir", "c#,msssql,jquery,automapper,unitofwork,fluentapi", "default.jpg", "Makale50", 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CvId",
                table: "Customers",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CvId",
                table: "Educations",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CvId",
                table: "Experiences",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_MyLanguages_CompetencyLevelId",
                table: "MyLanguages",
                column: "CompetencyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_MyLanguages_CvId",
                table: "MyLanguages",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ServiceId",
                table: "Portfolios",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioSkills_PortfolioId",
                table: "PortfolioSkills",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioSkills_SkillId",
                table: "PortfolioSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CompetencyLevelId",
                table: "Skills",
                column: "CompetencyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CvId",
                table: "Skills",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_CvId",
                table: "SocialMedias",
                column: "CvId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "MyLanguages");

            migrationBuilder.DropTable(
                name: "PortfolioSkills");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "CompetencyLevels");

            migrationBuilder.DropTable(
                name: "Cvs");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
