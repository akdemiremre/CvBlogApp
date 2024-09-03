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
                    About = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    YoutubeLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TwitterLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    InstagramLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FacebookLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LinkedInLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    GitHubLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WebsiteLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "83e98dec-b1dc-4188-8864-fefb6a46e18c", "Admin", "ADMIN" },
                    { 2, "dd921d34-c363-4482-a57d-f3bf54ef99f4", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FacebookLink", "FirstName", "GitHubLink", "InstagramLink", "LastName", "LinkedInLink", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwitterLink", "TwoFactorEnabled", "UserName", "WebsiteLink", "YoutubeLink" },
                values: new object[,]
                {
                    { 1, "Admin User About...", 0, "a4f2aef7-eb96-4715-a8b9-da8a2c96280c", "admin@emreakdemir.net", true, "https://facebook.com/", "Admin", "https://github.com/", "https://instagram.com/", "Admin", "https://linkedin.com/", false, null, "ADMIN@EMREAKDEMIR.NET", "ADMIN", "AQAAAAEAACcQAAAAEJ88W1hslKQXWkvSPulJat16Qx3bcElfrzv6C7uVw/vk3fKWSbEGPRac7qm7KkmqAg==", "+901111111111", true, "defaultUser.png", "57dd82ce-73ee-4d87-93c9-e94dfed5df39", "https://twitter.com/", false, "admin", "https://emreakdemir.net.com/", "https://youtube.com/" },
                    { 2, "Editor User About...", 0, "0b0c1d5c-e167-443f-882a-4fe229b1ec32", "editor@emreakdemir.net", true, "https://facebook.com/", "Editor", "https://github.com/", "https://instagram.com/", "Editor", "https://linkedin.com/", false, null, "EDITOR@EMREAKDEMIR.NET", "EDITOR", "AQAAAAEAACcQAAAAEMb2CQIvcdP2btmuPyREL//5Bd5RII/sp+TExOWLHdSMjStMMFvpaYrwon0FEa9hBw==", "++902222222222", true, "defaultUser.png", "bb721a8f-3b33-493c-a576-4a1b9c2f54a9", "https://twitter.com/", false, "editor", "https://emreakdemir.net.com/", "https://youtube.com/" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4377), "Açıklama1", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4381), "Kategori1", "CategoryMap'ten kaydedildi." },
                    { 2, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4441), "Açıklama2", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4443), "Kategori2", "CategoryMap'ten kaydedildi." },
                    { 3, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4463), "Açıklama3", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4466), "Kategori3", "CategoryMap'ten kaydedildi." },
                    { 4, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4479), "Açıklama4", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4480), "Kategori4", "CategoryMap'ten kaydedildi." },
                    { 5, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4496), "Açıklama5", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4498), "Kategori5", "CategoryMap'ten kaydedildi." },
                    { 6, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4518), "Açıklama6", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4519), "Kategori6", "CategoryMap'ten kaydedildi." },
                    { 7, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4537), "Açıklama7", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4540), "Kategori7", "CategoryMap'ten kaydedildi." },
                    { 8, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4556), "Açıklama8", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4558), "Kategori8", "CategoryMap'ten kaydedildi." },
                    { 9, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4576), "Açıklama9", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4578), "Kategori9", "CategoryMap'ten kaydedildi." },
                    { 10, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4602), "Açıklama10", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4605), "Kategori10", "CategoryMap'ten kaydedildi." },
                    { 11, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4625), "Açıklama11", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4626), "Kategori11", "CategoryMap'ten kaydedildi." },
                    { 12, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4636), "Açıklama12", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4637), "Kategori12", "CategoryMap'ten kaydedildi." },
                    { 13, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4645), "Açıklama13", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4646), "Kategori13", "CategoryMap'ten kaydedildi." },
                    { 14, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4654), "Açıklama14", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4655), "Kategori14", "CategoryMap'ten kaydedildi." },
                    { 15, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4663), "Açıklama15", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4664), "Kategori15", "CategoryMap'ten kaydedildi." },
                    { 16, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4672), "Açıklama16", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4673), "Kategori16", "CategoryMap'ten kaydedildi." },
                    { 17, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4681), "Açıklama17", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4682), "Kategori17", "CategoryMap'ten kaydedildi." },
                    { 18, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4694), "Açıklama18", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4696), "Kategori18", "CategoryMap'ten kaydedildi." },
                    { 19, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4714), "Açıklama19", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4717), "Kategori19", "CategoryMap'ten kaydedildi." },
                    { 20, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4818), "Açıklama20", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4821), "Kategori20", "CategoryMap'ten kaydedildi." },
                    { 21, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4840), "Açıklama21", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4843), "Kategori21", "CategoryMap'ten kaydedildi." },
                    { 22, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4859), "Açıklama22", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4861), "Kategori22", "CategoryMap'ten kaydedildi." },
                    { 23, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4876), "Açıklama23", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4877), "Kategori23", "CategoryMap'ten kaydedildi." },
                    { 24, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4885), "Açıklama24", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4886), "Kategori24", "CategoryMap'ten kaydedildi." },
                    { 25, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4894), "Açıklama25", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4896), "Kategori25", "CategoryMap'ten kaydedildi." },
                    { 26, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4905), "Açıklama26", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4905), "Kategori26", "CategoryMap'ten kaydedildi." },
                    { 27, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4913), "Açıklama27", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4914), "Kategori27", "CategoryMap'ten kaydedildi." },
                    { 28, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4922), "Açıklama28", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4923), "Kategori28", "CategoryMap'ten kaydedildi." },
                    { 29, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4929), "Açıklama29", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4930), "Kategori29", "CategoryMap'ten kaydedildi." },
                    { 30, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4937), "Açıklama30", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4938), "Kategori30", "CategoryMap'ten kaydedildi." },
                    { 31, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4951), "Açıklama31", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4953), "Kategori31", "CategoryMap'ten kaydedildi." },
                    { 32, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4971), "Açıklama32", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4974), "Kategori32", "CategoryMap'ten kaydedildi." },
                    { 33, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4989), "Açıklama33", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(4991), "Kategori33", "CategoryMap'ten kaydedildi." },
                    { 34, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5009), "Açıklama34", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5010), "Kategori34", "CategoryMap'ten kaydedildi." },
                    { 35, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5027), "Açıklama35", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5028), "Kategori35", "CategoryMap'ten kaydedildi." },
                    { 36, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5044), "Açıklama36", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5047), "Kategori36", "CategoryMap'ten kaydedildi." },
                    { 37, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5063), "Açıklama37", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5064), "Kategori37", "CategoryMap'ten kaydedildi." },
                    { 38, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5079), "Açıklama38", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5080), "Kategori38", "CategoryMap'ten kaydedildi." }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 39, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5096), "Açıklama39", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5097), "Kategori39", "CategoryMap'ten kaydedildi." },
                    { 40, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5158), "Açıklama40", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5161), "Kategori40", "CategoryMap'ten kaydedildi." },
                    { 41, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5243), "Açıklama41", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5244), "Kategori41", "CategoryMap'ten kaydedildi." },
                    { 42, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5265), "Açıklama42", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5267), "Kategori42", "CategoryMap'ten kaydedildi." },
                    { 43, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5284), "Açıklama43", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5286), "Kategori43", "CategoryMap'ten kaydedildi." },
                    { 44, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5300), "Açıklama44", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5301), "Kategori44", "CategoryMap'ten kaydedildi." },
                    { 45, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5309), "Açıklama45", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5310), "Kategori45", "CategoryMap'ten kaydedildi." },
                    { 46, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5317), "Açıklama46", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5319), "Kategori46", "CategoryMap'ten kaydedildi." },
                    { 47, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5327), "Açıklama47", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5327), "Kategori47", "CategoryMap'ten kaydedildi." },
                    { 48, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5335), "Açıklama48", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5336), "Kategori48", "CategoryMap'ten kaydedildi." },
                    { 49, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5344), "Açıklama49", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5345), "Kategori49", "CategoryMap'ten kaydedildi." },
                    { 50, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5352), "Açıklama50", true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 501, DateTimeKind.Local).AddTicks(5353), "Kategori50", "CategoryMap'ten kaydedildi." }
                });

            migrationBuilder.InsertData(
                table: "CompetencyLevels",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5302), true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5304), "beginner", "CompetencyLevel(beginner)" },
                    { 2, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5327), true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5328), "elementary", "CompetencyLevel(elementary)" },
                    { 3, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5334), true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5334), "pre-intermediate", "CompetencyLevel(pre-intermediate)" },
                    { 4, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5338), true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5339), "intermediate", "CompetencyLevel(intermediate)" },
                    { 5, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5343), true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5344), "upper-intermediate", "CompetencyLevel(upper-intermediate)" },
                    { 6, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5350), true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5351), "advanced", "CompetencyLevel(advanced)" },
                    { 7, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5355), true, false, "InitialCreate", new DateTime(2024, 8, 15, 14, 54, 44, 502, DateTimeKind.Local).AddTicks(5356), "expert-proficency", "CompetencyLevel(expert-proficency)" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 2 });

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
