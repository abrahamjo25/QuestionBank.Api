using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionBank.Infrastructure.Migrations
{
    public partial class ExamResultsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamResults_Modules_ModuleId",
                table: "ExamResults");

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9964), new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9964), new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(150), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(518), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(518), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(899), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1386), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1386), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1692), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1692), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1793), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1793), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2065), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2064), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2398), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2397), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3564), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3564), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3669), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3669), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3982), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3982), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4106), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4106), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4206), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4206), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4332), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4332), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4463), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4463), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4602), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4602), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4712), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4711), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4836), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4836), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4960), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4960), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5060), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5059), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5182), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5182), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5330), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5330), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5556), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5555), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5716), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5716), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5862), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5862), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(6182), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(6182), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(6760), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(6759), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7113), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7113), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7222), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7542), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7672), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7672), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7799), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7922), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8088), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8088), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8441), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8591), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8591), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8742), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8741), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9109), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9108), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9588), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9588), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 3, 19, 13, 42, 24, 325, DateTimeKind.Utc).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(23), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(22), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(153), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(152), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(388), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(388), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(520), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(520), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(691), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(690), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(839), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(839), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1087), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1087), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9217), new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1362), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1362), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1587), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1587), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1920), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1920), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2160), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2160), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2257), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2256), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2579), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2579), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2803), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2802), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2939), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2939), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3058), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3058), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3377), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3376), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3492), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3492), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3748), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3748), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4367), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4366), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4805), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4805), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4937), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4936), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5028), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5027), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5146), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5146), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5474), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5474), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5591), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5591), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5686), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5686), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5807), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6127), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6126), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6220), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6219), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6338), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6337), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6471), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6471), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6585), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6585), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6675), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6675), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6788), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6906), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6905), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7108), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7107), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7225), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7354), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7353), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7446), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7445), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7570), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7569), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7696), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7696), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7818), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7818), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7909), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7909), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8161), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8160), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8275), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8275), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8367), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8366), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8484), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8484), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8617), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8617), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8709), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8708), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8827), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8827), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8943), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8942), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(9055), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(9055), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(9849), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(9848), new DateTime(2024, 3, 19, 13, 42, 24, 326, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(533), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(532), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(766), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(766), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1895), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1895), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2138), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2138), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2366), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2366), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2819), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2819), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3033), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3032), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3246), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3246), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3510), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3510), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3741), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3741), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3957), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3956), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4199), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4198), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4413), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4412), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4625), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4625), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4862), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4861), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5129), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5129), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5577), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5577), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5876), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5876), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(6506), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(6726), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(6726), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7162), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7161), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7396), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7396), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7624), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7623), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7879), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7879), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8332), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8332), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8588), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8587), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "IdentityUserRole",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9448), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9448), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9229), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9314), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9313), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9322), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9322), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9323), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9323), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9325), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9324), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9326), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9326), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9327), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9327), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9329), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9328), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9332), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9332), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9333), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9333), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9335), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9335), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9336), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9336), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9338), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9338), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9339), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9339), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9340), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9340), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9343), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9342), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9344), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9344), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9345), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9345), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9346), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9346), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9349), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9348), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9350), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9350), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9351), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9351), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9352), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9353), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9353), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9355), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9355), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9356), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 3, 19, 13, 42, 24, 327, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9549), new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9549), new DateTime(2024, 3, 19, 13, 42, 24, 324, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.AddForeignKey(
                name: "FK_ExamResults_UserModules_ModuleId",
                table: "ExamResults",
                column: "ModuleId",
                principalTable: "UserModules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamResults_UserModules_ModuleId",
                table: "ExamResults");

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4276), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4642), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4642), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4800), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4799), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4956), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4956), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5117), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5117), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5237), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5237), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5390), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5390), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5811), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5811), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6260), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6260), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6414), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6413), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6560), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6560), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6680), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6680), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6831), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6981), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6981), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7101), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7100), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7252), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7251), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7403), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7402), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7668), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7668), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7835), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7835), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7988), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8255), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8255), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8409), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8409), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8527), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8526), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8675), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8675), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8828), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8828), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8977), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8977), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9094), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9094), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9245), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9245), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9536), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9535), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9691), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9691), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9848), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9847), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9966), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9965), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(119), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(119), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(272), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(271), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(421), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(420), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(540), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(539), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(846), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(845), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1054), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1053), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1175), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1174), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1342), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1342), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1612), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1766), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1766), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1926), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1926), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2106), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2106), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2229), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2229), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2399), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2399), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2551), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2668), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2667), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(3599), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(3602), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3008), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3007), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3306), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3306), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3432), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3432), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3536), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3535), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3666), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3665), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3895), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3895), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4027), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4027), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4155), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4155), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4287), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4287), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4391), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4544), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4544), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4680), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4680), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4816), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4816), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4922), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4922), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5067), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5067), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5200), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5199), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5303), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5303), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5438), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5438), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5571), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5700), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5803), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5802), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5948), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5947), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6080), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6079), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6209), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6208), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6314), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6314), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6451), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6451), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6582), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6581), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6685), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6814), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6814), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6943), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6943), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7083), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7082), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7186), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7186), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7479), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7479), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7615), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7615), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7724), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7724), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7876), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7876), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8149), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8149), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8394), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8394), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8563), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8563), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8668), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8667), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8814), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8813), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8949), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8948), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9083), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9082), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9195), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9194), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9326), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9326), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9456), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9455), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9590), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9589), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9693), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9693), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9823), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9822), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9965), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9965), new DateTime(2024, 3, 19, 11, 22, 7, 705, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(72), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(71), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(685), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(685), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1136), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1136), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1652), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1652), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1895), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1895), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2155), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2154), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2428), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2907), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2906), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3179), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3179), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3422), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3422), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3953), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3953), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4204), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4204), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4447), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4446), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4725), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4973), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4972), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5227), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5226), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5738), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5738), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5977), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5977), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6248), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6248), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6741), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6741), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6999), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6999), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7245), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7245), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7488), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7487), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7745), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7745), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7988), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7987), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8240), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8240), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8485), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8485), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8750), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8750), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8989), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8988), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9713), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9713), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "IdentityUserRole",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9501), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9501), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9628), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9628), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9633), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9633), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9635), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9634), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9636), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9636), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9637), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9637), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9638), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9638), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9640), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9639), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9641), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9641), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9642), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9642), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9643), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9643), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9645), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9644), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9646), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9646), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9648), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9647), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9649), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9649), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9651), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9651), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9653), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9652), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9654), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9654), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9655), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9655), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9657), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9656), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9658), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9658), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9660), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9659), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9661), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9661), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9662), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9662), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9665), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9665), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9666), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9666), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9668), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9668), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9669), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9669), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9671), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9670), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9673), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9673), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9675), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9674), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9676), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9676), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9677), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9677), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9678), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9678), new DateTime(2024, 3, 19, 11, 22, 7, 706, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(3992), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(3992), new DateTime(2024, 3, 19, 11, 22, 7, 704, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.AddForeignKey(
                name: "FK_ExamResults_Modules_ModuleId",
                table: "ExamResults",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
