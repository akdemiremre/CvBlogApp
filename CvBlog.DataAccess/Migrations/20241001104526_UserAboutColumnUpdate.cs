using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBlog.Data.Migrations
{
    public partial class UserAboutColumnUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "AspNetUsers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "48c07e94-9822-4736-8a7c-a33c5d0f053a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6f3ebd09-01ba-4745-8a2e-69cf739d988d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9e0b64c-ccca-4e18-a4ff-ff9f479c1bbb", "AQAAAAEAACcQAAAAEKbPpnCymV2v9TJXCCOuwZhqsJjhtEFaUkTJenAdgRuFAASYIuTVgZ+v/tmw21coAA==", "67009e56-e2e4-4e04-8597-c14663fcdf59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fddfe27-a0b2-41dc-a7af-00cac9f510ac", "AQAAAAEAACcQAAAAEKFCS88Tng3o7iQTFx+OiG0P531bp+liYaoKkCVBfibnm5LVBffjFCqB66W/RuIBbA==", "3c6a5025-12d2-4688-91c7-65e49829ef34" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3879), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3904), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3977), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3987), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3996), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4000), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4024), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4027), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4036), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4043), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4054), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4061), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4110), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4121), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4124), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4129), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4132), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4143), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4147), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4151), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4158), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4165), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4172), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4217), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4221), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7299), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7305), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 10, 1, 13, 45, 25, 61, DateTimeKind.Local).AddTicks(7309) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "AspNetUsers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4590d58b-abed-41eb-b96d-2b52738ccb8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bd1b370c-8b56-4489-ada3-359ab513c6e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9903688b-5e16-4a56-a8c9-cf453a81c8da", "AQAAAAEAACcQAAAAELGpxPjfewHbw6E6wYCMeD461fMfxa7QhxGsOnahZKFbUhsOk3NrZW65RBq27g6zVw==", "19253be3-dca1-4df8-8ddd-f2c7eafa8f0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95310858-ba9f-459b-b5b8-dcb660e8a127", "AQAAAAEAACcQAAAAEE17qA9likTIbUL0zQaSVr6k31kXyGeoZe21S+I0Z3vwgoG4hLVCtSborQeDjENsaA==", "4200153d-0c6f-4ef1-923a-ff5640b3d720" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8744), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8752), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8760), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8777), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8792), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8799), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8810), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8818), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8895), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8902), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8910), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8917), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8925), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8935), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8942), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8950), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8958), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8965), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8973), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8981), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8988), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9011), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9020), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9028), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9051), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9167), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9198), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9228), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 10, 1, 13, 39, 17, 38, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6788), new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6862), new DateTime(2024, 10, 1, 13, 39, 17, 39, DateTimeKind.Local).AddTicks(6863) });
        }
    }
}
