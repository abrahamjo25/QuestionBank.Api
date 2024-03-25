using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionBank.Infrastructure.Migrations
{
    public partial class ExamResultsNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamResults_UserModules_ModuleId",
                table: "ExamResults");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "ExamResults",
                newName: "UserModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamResults_ModuleId",
                table: "ExamResults",
                newName: "IX_ExamResults_UserModuleId");

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3027), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3027), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3299), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3298), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3422), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3422), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3546), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3546), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3647), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3775), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3774), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3921), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3920), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4023), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4022), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4148), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4148), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4272), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4391), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4611), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4611), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4744), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4744), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4844), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4965), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4965), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5087), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5087), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5182), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5182), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5303), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5302), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5554), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5554), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5653), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5653), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5776), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5776), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5993), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5993), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6131), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6131), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6255), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6255), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6606), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6606), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7203), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7203), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7868), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7867), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8070), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8070), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8625), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8625), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9159), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9274), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9273), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9627), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9626), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(461), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(461), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(824), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(824), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1392), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1391), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1497), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1639), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1986), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1986), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2107), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2107), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2323), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2323), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2516), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2574), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2574), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2840), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2840), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2931), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2930), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3043), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3042), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3157), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3157), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3264), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3349), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3349), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3462), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3462), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3573), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3573), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3768), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3767), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3880), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4002), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4001), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4205), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4205), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4319), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4429), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4429), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4626), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4626), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4734), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4734), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4818), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4818), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5062), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5062), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5179), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5179), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5269), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5269), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5377), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5377), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5593), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5593), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5679), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5678), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5789), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5899), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5899), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5983), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6214), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6213), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6333), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6333), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6531), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6530), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6758), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6757), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6844), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6844), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7170), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7169), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7592), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7592), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7702), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7702), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7810), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7810), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8124), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8124), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8234), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8234), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8319), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8318), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8544), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8544), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8877), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8877), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9209), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9209), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9416), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9416), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9617), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9617), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 3, 19, 13, 47, 13, 546, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(43), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(43), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(257), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(257), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(483), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(483), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(681), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(681), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(878), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(877), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1103), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1103), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1317), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1317), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1527), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1527), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1752), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1956), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1956), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2155), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2155), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2794), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2794), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3018), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3018), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3218), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3218), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3641), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3640), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4044), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4043), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4967), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4967), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5320), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5752), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5751), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5961), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5961), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6193), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6193), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6392), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6392), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "IdentityUserRole",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7066), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6959), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6960), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6960), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6961), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7004), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7004), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7006), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7007), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7006), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7009), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7009), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7012), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7012), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7014), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7014), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7016), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7016), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7019), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7019), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7020), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7020), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7022), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7022), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 3, 19, 13, 47, 13, 547, DateTimeKind.Utc).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 3, 19, 13, 47, 13, 545, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.AddForeignKey(
                name: "FK_ExamResults_UserModules_UserModuleId",
                table: "ExamResults",
                column: "UserModuleId",
                principalTable: "UserModules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamResults_UserModules_UserModuleId",
                table: "ExamResults");

            migrationBuilder.RenameColumn(
                name: "UserModuleId",
                table: "ExamResults",
                newName: "ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamResults_UserModuleId",
                table: "ExamResults",
                newName: "IX_ExamResults_ModuleId");

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
    }
}
