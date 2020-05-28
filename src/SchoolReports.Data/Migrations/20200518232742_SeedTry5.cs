using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReportWriterData.Migrations
{
    public partial class SeedTry5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DOB", "Forename", "Gender", "Surname" },
                values: new object[] { new DateTime(2001, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicky", "F", "Manosalvas" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DOB", "Forename", "Gender", "Surname", "TeachingGroupId" },
                values: new object[,]
                {
                    { 4, new DateTime(2003, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seb", "M", "Manolsalvas", 1 },
                    { 5, new DateTime(2012, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sammy", "M", "Hanley", 1 },
                    { 6, new DateTime(2018, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah", "M", "Hanley", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DOB", "Forename", "Gender", "Surname" },
                values: new object[] { new DateTime(2012, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sammy", "M", "Hanley" });
        }
    }
}
