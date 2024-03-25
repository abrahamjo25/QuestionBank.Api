using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionBank.Infrastructure.Migrations
{
    public partial class ExamResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamResults",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<long>(type: "bigint", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeZoneInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordStatus = table.Column<int>(type: "int", nullable: false),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamResults_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_ModuleId",
                table: "ExamResults",
                column: "ModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamResults");

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5459), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5458), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5601), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5601), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5763), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5763), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5910), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5910), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6059), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6058), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6157), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6156), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6303), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6302), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6446), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6446), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6540), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6540), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6689), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6689), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6821), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6821), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7186), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7186), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7318), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7317), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7494), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7493), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7639), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7639), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7755), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7755), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7847), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7847), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7964), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7963), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8092), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8092), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8236), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8236), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8331), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8330), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8464), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8464), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8579), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8579), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8672), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8672), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8791), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8791), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8908), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8908), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9116), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9116), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9408), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9408), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9502), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9502), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9652), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9652), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9807), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9806), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9905), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9905), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(56), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(56), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(201), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(294), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(294), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(445), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(444), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(576), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(576), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(722), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(721), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(816), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(816), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(963), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(963), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1176), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1176), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1323), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1323), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1463), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1462), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1582), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1582), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1712), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1712), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1808), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1807), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1922), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1922), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2052), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2051), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2146), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2145), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2412), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2412), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "ApiClaim",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2622), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2622), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(4942), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(4947), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2867), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2867), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2985), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2985), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3088), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3088), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3169), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3169), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3371), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3370), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3451), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3451), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3572), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3572), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3677), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3677), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3777), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3777), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3858), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3858), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3959), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3959), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4063), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4063), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4164), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4164), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4244), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4244), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4345), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4345), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4446), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4445), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4642), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4642), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4917), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4916), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4995), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4995), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5115), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5115), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5248), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5248), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5364), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5364), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5445), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5445), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5579), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5578), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5708), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5707), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6069), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6069), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6197), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6197), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6276), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6276), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6395), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6395), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6515), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6515), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6631), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6630), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6710), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6710), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6832), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6831), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6949), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6949), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7089), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7089), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7173), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7173), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7303), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7303), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7594), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7593), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7730), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7730), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7954), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7953), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8032), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8031), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8136), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8135), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8236), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8236), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8348), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8348), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8430), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8534), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8534), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8635), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8635), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8713), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8713), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8819), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8819), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "ClientAPIResource",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8924), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9271), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9270), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9587), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9587), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9802), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9801), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 2, 22, 9, 14, 38, 619, DateTimeKind.Utc).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(216), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(407), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(407), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(621), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(620), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(835), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(835), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1256), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1256), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1448), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1448), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1638), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2043), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2043), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2247), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2247), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2464), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2464), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2657), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2657), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2846), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2846), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3058), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3058), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3251), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3452), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3452), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3668), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3668), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4051), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4050), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4266), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4266), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4459), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4459), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4662), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4662), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4876), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4875), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5068), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5068), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5256), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5256), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5468), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5467), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5664), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5664), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "ClientClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5868), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5867), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6380), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6380), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "IdentityUserRole",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6414), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6413), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6247), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6246), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6323), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6323), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6326), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6328), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6328), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6329), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6329), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6331), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6331), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6332), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6332), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6333), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6333), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6335), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6335), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6336), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6336), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6338), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6338), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6339), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6339), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6340), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6340), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6341), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6341), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6342), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6342), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6343), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6343), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6345), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6345), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6346), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6346), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6347), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6347), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6348), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6348), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6349), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6349), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6351), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6351), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6352), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6352), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6353), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6353), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6354), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6354), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6355), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6355), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6356), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6356), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6357), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6357), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6358), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6358), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "RoleClaim",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6359), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6359), new DateTime(2024, 2, 22, 9, 14, 38, 620, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "LastUpdateDate", "RegisteredDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5192), new DateTime(2024, 2, 22, 9, 14, 38, 618, DateTimeKind.Utc).AddTicks(5192) });
        }
    }
}
