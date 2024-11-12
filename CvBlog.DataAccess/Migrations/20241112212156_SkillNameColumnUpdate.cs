using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBlog.Data.Migrations
{
    public partial class SkillNameColumnUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skills",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "926926a1-94eb-49fd-8a6a-f33d3b57097a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3d1e5ade-588f-4c5a-987d-1f95e1666a25");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39ca5683-b3d1-4f7a-aca1-d76e9f6d6d19", "AQAAAAEAACcQAAAAEHXWRg5uccj84zcBQD9B3cW8/6gUgC4b8eNE2IqjHaR0JA5/ew1dDt6i7UwH2AAMiA==", "a31d64d2-7b05-43e7-9044-199a8574f65d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4e35bb5-78e4-4e48-9138-9ce5278ae001", "AQAAAAEAACcQAAAAEH3PcxbAYNyQXoxrFZ8XGpRRBX9jLFnmcZw2rk9gYWe3NGwObkg4i6ophZokxSz0rQ==", "88918253-3571-41e3-888e-2c5905e69224" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4807), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4812), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4822), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4829), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4839), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4844), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4953), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4962), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4967), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4971), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4976), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4985), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4994), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5003), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5007), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5052), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5058), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5063), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5072), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5077), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5081), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5086), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5090), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5094), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5108), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5112), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5117), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5126), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5130), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9165), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "CompetencyLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 11, 13, 0, 21, 55, 798, DateTimeKind.Local).AddTicks(9177) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Skills",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
    }
}
