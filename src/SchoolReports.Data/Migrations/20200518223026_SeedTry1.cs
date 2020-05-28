using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReportWriterData.Migrations
{
    public partial class SeedTry1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DOB", "Forename", "Gender", "Surname", "TeachingGroupId" },
                values: new object[] { 1, new DateTime(2020, 5, 18, 23, 30, 25, 654, DateTimeKind.Local).AddTicks(4957), "Abel", "M", "Magwitch", null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DOB", "Forename", "Gender", "Surname", "TeachingGroupId" },
                values: new object[] { 2, new DateTime(2020, 5, 18, 23, 30, 25, 662, DateTimeKind.Local).AddTicks(760), "Brenda", "F", "Micklethwaite", null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DOB", "Forename", "Gender", "Surname", "TeachingGroupId" },
                values: new object[] { 3, new DateTime(2020, 5, 18, 23, 30, 25, 662, DateTimeKind.Local).AddTicks(913), "Charlie", "M", "Parker", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
