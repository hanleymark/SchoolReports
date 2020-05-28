using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReportWriterData.Migrations
{
    public partial class SeedTry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TeachingGroups",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "6MH" });

            migrationBuilder.InsertData(
                table: "TeachingGroups",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "6GI" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "Forename", "Surname", "TeachingGroupId" },
                values: new object[] { new DateTime(1970, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", "Hanley", 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DOB", "Forename", "Surname", "TeachingGroupId" },
                values: new object[] { new DateTime(1978, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veronica", "Hanley", 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DOB", "Forename", "Surname", "TeachingGroupId" },
                values: new object[] { new DateTime(2012, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sammy", "Hanley", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeachingGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeachingGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "TeachingGroupId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "TeachingGroupId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeachingGroupId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "Forename", "Surname", "TeachingGroupId" },
                values: new object[] { new DateTime(2020, 5, 18, 23, 30, 25, 654, DateTimeKind.Local).AddTicks(4957), "Abel", "Magwitch", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DOB", "Forename", "Surname", "TeachingGroupId" },
                values: new object[] { new DateTime(2020, 5, 18, 23, 30, 25, 662, DateTimeKind.Local).AddTicks(760), "Brenda", "Micklethwaite", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DOB", "Forename", "Surname", "TeachingGroupId" },
                values: new object[] { new DateTime(2020, 5, 18, 23, 30, 25, 662, DateTimeKind.Local).AddTicks(913), "Charlie", "Parker", null });
        }
    }
}
