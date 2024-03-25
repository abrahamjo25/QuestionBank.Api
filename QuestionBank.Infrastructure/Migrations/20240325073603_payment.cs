using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionBank.Infrastructure.Migrations
{
    public partial class payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Payment",
                table: "UserModules",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "UserModules",
                type: "nvarchar(max)",
                nullable: true);

            //migrationBuilder.UpdateData(
            //    table: "ApiClaim",
            //    keyColumn: "Id",
            //    keyValue: 1L,
            //    columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
            //    values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3522), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3521), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3521) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 2L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3663), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3663), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3663) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 3L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3787), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3787), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3786) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 4L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3915), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3915), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3915) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 5L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4036), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4036), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4036) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 6L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4128), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4128), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4128) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 7L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4248), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4247), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4247) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 8L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4368), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4368), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4368) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 9L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4459), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4459), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4458) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 10L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4579), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4579) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 11L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4698), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4698), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4697) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 12L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4788) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 13L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4924), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4924), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(4923) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 14L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5041), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5041), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5040) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 15L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5163), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5162), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5162) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 16L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5256), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5256), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5255) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 17L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5414), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5414), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5414) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 18L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5533), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5532) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 19L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5625), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5625), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5624) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 20L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5745), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5744), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5744) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 21L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5863) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 22L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5981), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(5980) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 23L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6070), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6070), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6070) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 24L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6423) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 25L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6544), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6544), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6543) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 26L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6637), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6637), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6636) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 27L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(6966) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 28L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7306), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7306), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7306) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 29L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7399), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7399) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 30L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7522) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 31L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7641), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7640), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7640) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 32L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(7756) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 33L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8052), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8052), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8052) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 34L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8169), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8169), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8168) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 35L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8768), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8768), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8767) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 36L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(8878) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 37L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9008), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9008), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9007) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 38L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9340), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9340) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 39L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9639), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9639), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9638) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 40L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9972), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9972), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(9972) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 41L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(94), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(94), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(93) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 42L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(212), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(211), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(211) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 43L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(304), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(304), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(304) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 44L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(630), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(630), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(629) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 45L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1064), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1064), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1063) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 46L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1237) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 47L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1585), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1585), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1585) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 48L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1909), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1909), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(1908) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 49L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2028), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2028), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2028) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 50L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2125), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2125), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2124) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 51L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2450) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 52L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2781), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2781), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2781) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 53L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2875), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2875), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2874) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 54L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2992), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2992), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(2992) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 55L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3325), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3324), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3324) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 56L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3414) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 57L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3533), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3533), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3533) });

        //    migrationBuilder.UpdateData(
        //        table: "Client",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(2962), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(2964), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(2961) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3998), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3998), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(3998) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 2L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4128), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4128), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4127) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 3L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4696), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4696), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4696) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 4L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4786) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 5L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4913), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4913), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(4912) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 6L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5026), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5026), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5026) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 7L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5111), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5111), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5111) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 8L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5251), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5251), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5250) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 9L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5377), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5377), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5377) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 10L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5710) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 11L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5799) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 12L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(5925) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 13L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6061), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6061) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 14L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6205), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6205), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6204) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 15L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6298), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6297), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6297) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 16L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6413), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6413), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6413) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 17L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6527), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6526), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6526) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 18L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6617), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6617), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6617) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 19L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6731) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 20L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6864), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6864), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6864) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 21L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(6976) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 22L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7272) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 23L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7378), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7377), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7377) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 24L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7489), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7489), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7489) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 25L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7599), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7599), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7599) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 26L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7684), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7684), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7684) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 27L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7812), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7812) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 28L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7920), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7920), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(7919) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 29L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8023), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8023), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8023) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 30L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8108), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8108), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8107) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 31L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8227), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8227), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8227) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 32L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8336), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8335), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8335) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 33L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8419), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8418), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8418) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 34L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8735) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 35L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8845), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8845), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8845) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 36L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8963), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8963), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(8962) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 37L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9048) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 38L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9163), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9163), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9162) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 39L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9280), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9280), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9280) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 40L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9392) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 41L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9478), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9478), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9478) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 42L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9603), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9602), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9602) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 43L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9713), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9713), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9712) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 44L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9798), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9798), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9798) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 45L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 3, 25, 7, 36, 2, 275, DateTimeKind.Utc).AddTicks(9914) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 46L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(28), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(28), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(28) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 47L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(135), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(135), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(135) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 48L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(219), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(218) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 49L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(330), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(330), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(329) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 50L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(462), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(462), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(462) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 51L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(588), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(588), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(588) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 52L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(678), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(677), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(677) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 53L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(799), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(799), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(798) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 54L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(908), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(907), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(907) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 55L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(992) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 56L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1101), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1101), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1101) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 57L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1233), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1233), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1233) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1570) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 2L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1906), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(1905) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 3L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2105), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2105), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2104) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 4L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2310), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2310), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2309) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 5L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2527), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2527), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2527) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 6L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2737), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2737), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2737) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 7L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2929), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2929), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(2929) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 8L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3143), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3143), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3142) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 9L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3336), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3336), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3336) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 10L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3538), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3537), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3537) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 11L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3751), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3751), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3751) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 12L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3968), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3968), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(3968) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 13L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4163), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4162), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4162) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 14L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4377), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4377), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4376) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 15L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4781), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4781), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4780) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 16L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(4977) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 17L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5183), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5183), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5183) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 18L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5381), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5381), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5380) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 19L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5564), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5564), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5564) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 20L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5770) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 21L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5955), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5955), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(5954) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 22L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6149), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6149), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6149) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 23L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6353), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6353), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6353) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 24L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6546), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6546), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6546) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 25L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6730) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 26L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6937), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6936), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(6936) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 27L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7123), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7122), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7122) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 28L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7316), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7316), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7315) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 29L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7521) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 30L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7711), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7710), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7709) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 31L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7898), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7898), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(7898) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 32L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8146) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 33L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8335), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8335), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8335) });

        //    migrationBuilder.UpdateData(
        //        table: "IdentityUser",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8861), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8861), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8861) });

        //    migrationBuilder.UpdateData(
        //        table: "IdentityUserRole",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8877) });

        //    migrationBuilder.UpdateData(
        //        table: "Role",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8694), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8694), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8694) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8770), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8769), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8769) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 2L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8773), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8773), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8772) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 3L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8774), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8774), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8774) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 4L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8779), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8779), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8779) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 5L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8780), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8780), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8780) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 6L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8781), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8781), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8781) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 7L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8782), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8782), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8782) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 8L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8783), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8783), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8783) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 9L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8784), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8784), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8784) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 10L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8785), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8785), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8785) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 11L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8786), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8786), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8786) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 12L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8787), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8787), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8787) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 13L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8788) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 14L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8789), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8789), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8789) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 15L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8814), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8813), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8813) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 16L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8815), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8815), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8815) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 17L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8816), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8816), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8816) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 18L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8817) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 19L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8818), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8818), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8818) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 20L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8821), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8820), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8820) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 21L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8822), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8821), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8821) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 22L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8822), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8822) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 23L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8824), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8823) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 24L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8825), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8824), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8824) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 25L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8825), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8825) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 26L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8827), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8826) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 27L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8828), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8828), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8827) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 28L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8829), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8829), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8828) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 29L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8830), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8830), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8829) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 30L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8831), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8831), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8830) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 31L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8832), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8832), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8831) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 32L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8833), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8833), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8832) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 33L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8834), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8834), new DateTime(2024, 3, 25, 7, 36, 2, 276, DateTimeKind.Utc).AddTicks(8833) });

        //    migrationBuilder.UpdateData(
        //        table: "Service",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3266), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3266), new DateTime(2024, 3, 25, 7, 36, 2, 274, DateTimeKind.Utc).AddTicks(3266) });
        //}

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropColumn(
        //        name: "Payment",
        //        table: "UserModules");

        //    migrationBuilder.DropColumn(
        //        name: "Reference",
        //        table: "UserModules");

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3027), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3027), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3026) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 2L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3163) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 3L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3299), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3298), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3298) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 4L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3422), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3422), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3421) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 5L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3546), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3546), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3546) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 6L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3647), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3646) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 7L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3775), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3774), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3774) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 8L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3921), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3920), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3920) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 9L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4023), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4022), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4022) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 10L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4148), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4148), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4148) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 11L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4272), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4272) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 12L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4391), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4391) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 13L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4487) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 14L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4611), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4611), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4610) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 15L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4744), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4744), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4743) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 16L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4844), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4844) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 17L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4965), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4965), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4964) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 18L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5087), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5087), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5087) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 19L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5182), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5182), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5182) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 20L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5303), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5302), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5302) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 21L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5430) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 22L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5554), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5554), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5554) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 23L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5653), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5653), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5653) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 24L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5776), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5776), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5775) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 25L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5897) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 26L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5993), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5993), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5993) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 27L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6131), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6131), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6131) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 28L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6255), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6255), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6254) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 29L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6350) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 30L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6477) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 31L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6606), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6606), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6605) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 32L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6732) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 33L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6831) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 34L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6957) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 35L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7203), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7203), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7203) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 36L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7307) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 37L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7868), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7867), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7867) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 38L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8070), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8070), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8070) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 39L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8625), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8625), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8624) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 40L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8809) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 41L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8999) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 42L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9159) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 43L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9274), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9273), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9273) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 44L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9627), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9626), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9626) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 45L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(461), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(461), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(460) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 46L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(824), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(824), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(824) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 47L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(959) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 48L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1255) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 49L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1392), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1391), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1391) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 50L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1497), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1496) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 51L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1639), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1638) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 52L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1759) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 53L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1856) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 54L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1986), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1986), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1985) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 55L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2107), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2107), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2107) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 56L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2201) });

        //    migrationBuilder.UpdateData(
        //        table: "ApiClaim",
        //        keyColumn: "Id",
        //        keyValue: 57L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2323), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2323), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2323) });

        //    migrationBuilder.UpdateData(
        //        table: "Client",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2516), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2511) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2574), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2574), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2574) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 2L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2712) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 3L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2840), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2840), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2839) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 4L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2931), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2930), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2930) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 5L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3043), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3042), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3042) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 6L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3157), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3157), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3156) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 7L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3264), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3263) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 8L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3349), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3349), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3348) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 9L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3462), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3462), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3462) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 10L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3573), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3573), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3573) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 11L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3656) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 12L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3768), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3767), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3767) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 13L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3880), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3880) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 14L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4002), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4001), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4001) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 15L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4090) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 16L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4205), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4205), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4205) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 17L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4319), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4319) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 18L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4429), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4429), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4429) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 19L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4516) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 20L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4626), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4626), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4625) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 21L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4734), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4734), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4733) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 22L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4818), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4818), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4818) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 23L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4927) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 24L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5062), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5062), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5062) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 25L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5179), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5179), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5179) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 26L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5269), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5269), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5268) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 27L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5377), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5377), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5377) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 28L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5486) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 29L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5593), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5593), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5592) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 30L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5679), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5678), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5678) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 31L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5789) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 32L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5899), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5899), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5898) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 33L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5983), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5982) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 34L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6090) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 35L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6214), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6213), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6213) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 36L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6333), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6333), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6332) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 37L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6420) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 38L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6531), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6530), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6530) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 39L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6642) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 40L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6758), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6757), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6757) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 41L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6844), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6844), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6844) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 42L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6975) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 43L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7085) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 44L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7170), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7169), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7169) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 45L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7279) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 46L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7387) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 47L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7503) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 48L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7592), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7592), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7592) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 49L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7702), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7702), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7702) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 50L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7810), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7810), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7810) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 51L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7923) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 52L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8009) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 53L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8124), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8124), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8124) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 54L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8234), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8234), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8234) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 55L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8319), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8318), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8318) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 56L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8430) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientAPIResource",
        //        keyColumn: "Id",
        //        keyValue: 57L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8544), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8544), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8543) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8877), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8877), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8876) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 2L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9209), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9209), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9209) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 3L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9416), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9416), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9416) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 4L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9617), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9617), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9617) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 5L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9845) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 6L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(43), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(43), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(43) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 7L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(257), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(257), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(257) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 8L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(483), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(483), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(482) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 9L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(681), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(681), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(681) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 10L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(878), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(877), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(877) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 11L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1103), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1103), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1103) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 12L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1317), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1317), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1317) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 13L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1527), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1527), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1526) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 14L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1752), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1751) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 15L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1956), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1956), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1955) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 16L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2155), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2155), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2154) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 17L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2381) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 18L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2585) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 19L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2794), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2794), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2794) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 20L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3018), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3018), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3018) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 21L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3218), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3218), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3218) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 22L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3417) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 23L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3641), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3640), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3640) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 24L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3838) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 25L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4044), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4043), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4043) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 26L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4579) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 27L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4967), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4967), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4967) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 28L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5320) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 29L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5550) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 30L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5752), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5751), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5751) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 31L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5961), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5961), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5960) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 32L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6193), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6193), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6193) });

        //    migrationBuilder.UpdateData(
        //        table: "ClientClaim",
        //        keyColumn: "Id",
        //        keyValue: 33L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6392), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6392), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6392) });

        //    migrationBuilder.UpdateData(
        //        table: "IdentityUser",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7050) });

        //    migrationBuilder.UpdateData(
        //        table: "IdentityUserRole",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7066), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7065) });

        //    migrationBuilder.UpdateData(
        //        table: "Role",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6884) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6955) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 2L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6959), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6958) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 3L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6960), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6960), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6959) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 4L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6960) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 5L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6961) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 6L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6962) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 7L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6963) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 8L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6965) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 9L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6966) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 10L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6967) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 11L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6968) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 12L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6969) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 13L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6970) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 14L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7003) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 15L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7004), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7004), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7004) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 16L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7006), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7005) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 17L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7007), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7006), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7006) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 18L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7009), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7009), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7008) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 19L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7009) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 20L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7012), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7012), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7011) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 21L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7012) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 22L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7014), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7014), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7013) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 23L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7014) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 24L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7016), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7016), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7015) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 25L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7016) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 26L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7017) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 27L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7019), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7019), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7018) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 28L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7020), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7020), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7019) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 29L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7020) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 30L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7022), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7022), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7021) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 31L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7022) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 32L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7023) });

        //    migrationBuilder.UpdateData(
        //        table: "RoleClaim",
        //        keyColumn: "Id",
        //        keyValue: 33L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7024) });

        //    migrationBuilder.UpdateData(
        //        table: "Service",
        //        keyColumn: "Id",
        //        keyValue: 1L,
        //        columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
        //        values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2792) });
        }
    }
}
