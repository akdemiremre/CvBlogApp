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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_Articles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(2986), "Açıklama1", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(2987), "Kategori1", "CategoryMap'ten kaydedildi." },
                    { 2, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3005), "Açıklama2", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3006), "Kategori2", "CategoryMap'ten kaydedildi." },
                    { 3, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3010), "Açıklama3", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3011), "Kategori3", "CategoryMap'ten kaydedildi." },
                    { 4, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3014), "Açıklama4", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3014), "Kategori4", "CategoryMap'ten kaydedildi." },
                    { 5, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3018), "Açıklama5", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3018), "Kategori5", "CategoryMap'ten kaydedildi." },
                    { 6, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3024), "Açıklama6", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3024), "Kategori6", "CategoryMap'ten kaydedildi." },
                    { 7, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3028), "Açıklama7", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3028), "Kategori7", "CategoryMap'ten kaydedildi." },
                    { 8, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3032), "Açıklama8", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3033), "Kategori8", "CategoryMap'ten kaydedildi." },
                    { 9, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3036), "Açıklama9", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3037), "Kategori9", "CategoryMap'ten kaydedildi." },
                    { 10, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3042), "Açıklama10", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3043), "Kategori10", "CategoryMap'ten kaydedildi." },
                    { 11, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3046), "Açıklama11", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3047), "Kategori11", "CategoryMap'ten kaydedildi." },
                    { 12, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3051), "Açıklama12", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3051), "Kategori12", "CategoryMap'ten kaydedildi." },
                    { 13, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3055), "Açıklama13", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3055), "Kategori13", "CategoryMap'ten kaydedildi." },
                    { 14, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3059), "Açıklama14", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3059), "Kategori14", "CategoryMap'ten kaydedildi." },
                    { 15, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3063), "Açıklama15", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3063), "Kategori15", "CategoryMap'ten kaydedildi." },
                    { 16, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3067), "Açıklama16", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3068), "Kategori16", "CategoryMap'ten kaydedildi." },
                    { 17, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3071), "Açıklama17", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3072), "Kategori17", "CategoryMap'ten kaydedildi." },
                    { 18, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3077), "Açıklama18", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3077), "Kategori18", "CategoryMap'ten kaydedildi." },
                    { 19, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3081), "Açıklama19", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3082), "Kategori19", "CategoryMap'ten kaydedildi." },
                    { 20, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3085), "Açıklama20", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3086), "Kategori20", "CategoryMap'ten kaydedildi." },
                    { 21, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3089), "Açıklama21", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3090), "Kategori21", "CategoryMap'ten kaydedildi." },
                    { 22, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3093), "Açıklama22", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3094), "Kategori22", "CategoryMap'ten kaydedildi." },
                    { 23, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3103), "Açıklama23", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3104), "Kategori23", "CategoryMap'ten kaydedildi." },
                    { 24, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3108), "Açıklama24", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3108), "Kategori24", "CategoryMap'ten kaydedildi." },
                    { 25, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3112), "Açıklama25", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3112), "Kategori25", "CategoryMap'ten kaydedildi." },
                    { 26, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3116), "Açıklama26", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3117), "Kategori26", "CategoryMap'ten kaydedildi." },
                    { 27, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3120), "Açıklama27", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3121), "Kategori27", "CategoryMap'ten kaydedildi." },
                    { 28, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3124), "Açıklama28", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3125), "Kategori28", "CategoryMap'ten kaydedildi." },
                    { 29, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3128), "Açıklama29", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3129), "Kategori29", "CategoryMap'ten kaydedildi." },
                    { 30, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3133), "Açıklama30", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3133), "Kategori30", "CategoryMap'ten kaydedildi." },
                    { 31, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3137), "Açıklama31", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3137), "Kategori31", "CategoryMap'ten kaydedildi." },
                    { 32, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3141), "Açıklama32", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3141), "Kategori32", "CategoryMap'ten kaydedildi." },
                    { 33, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3145), "Açıklama33", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3145), "Kategori33", "CategoryMap'ten kaydedildi." },
                    { 34, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3150), "Açıklama34", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3151), "Kategori34", "CategoryMap'ten kaydedildi." },
                    { 35, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3154), "Açıklama35", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3155), "Kategori35", "CategoryMap'ten kaydedildi." },
                    { 36, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3159), "Açıklama36", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3159), "Kategori36", "CategoryMap'ten kaydedildi." },
                    { 37, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3163), "Açıklama37", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3163), "Kategori37", "CategoryMap'ten kaydedildi." },
                    { 38, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3167), "Açıklama38", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3167), "Kategori38", "CategoryMap'ten kaydedildi." },
                    { 39, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3171), "Açıklama39", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3172), "Kategori39", "CategoryMap'ten kaydedildi." },
                    { 40, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3175), "Açıklama40", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3176), "Kategori40", "CategoryMap'ten kaydedildi." },
                    { 41, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3179), "Açıklama41", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3180), "Kategori41", "CategoryMap'ten kaydedildi." },
                    { 42, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3183), "Açıklama42", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3184), "Kategori42", "CategoryMap'ten kaydedildi." }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 43, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3187), "Açıklama43", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3188), "Kategori43", "CategoryMap'ten kaydedildi." },
                    { 44, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3196), "Açıklama44", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3197), "Kategori44", "CategoryMap'ten kaydedildi." },
                    { 45, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3201), "Açıklama45", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3201), "Kategori45", "CategoryMap'ten kaydedildi." },
                    { 46, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3205), "Açıklama46", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3205), "Kategori46", "CategoryMap'ten kaydedildi." },
                    { 47, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3209), "Açıklama47", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3209), "Kategori47", "CategoryMap'ten kaydedildi." },
                    { 48, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3213), "Açıklama48", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3214), "Kategori48", "CategoryMap'ten kaydedildi." },
                    { 49, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3217), "Açıklama49", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3218), "Kategori49", "CategoryMap'ten kaydedildi." },
                    { 50, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3221), "Açıklama50", true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(3222), "Kategori50", "CategoryMap'ten kaydedildi." }
                });

            migrationBuilder.InsertData(
                table: "CompetencyLevels",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6807), true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6808), "beginner", "CompetencyLevel(beginner)" },
                    { 2, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6826), true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6826), "elementary", "CompetencyLevel(elementary)" },
                    { 3, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6830), true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6831), "pre-intermediate", "CompetencyLevel(pre-intermediate)" },
                    { 4, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6834), true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6835), "intermediate", "CompetencyLevel(intermediate)" },
                    { 5, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6839), true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6839), "upper-intermediate", "CompetencyLevel(upper-intermediate)" },
                    { 6, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6845), true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6845), "advanced", "CompetencyLevel(advanced)" },
                    { 7, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6849), true, false, "InitialCreate", new DateTime(2024, 5, 7, 23, 2, 7, 341, DateTimeKind.Local).AddTicks(6850), "expert-proficency", "CompetencyLevel(expert-proficency)" }
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "CompetencyLevels");

            migrationBuilder.DropTable(
                name: "Cvs");
        }
    }
}
