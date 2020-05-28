using Microsoft.EntityFrameworkCore.Migrations;

namespace ReportWriterData.Migrations
{
    public partial class ReversedStudentReportRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Reports_ReportId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ReportId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Reports",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_StudentId",
                table: "Reports",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Students_StudentId",
                table: "Reports",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Students_StudentId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_StudentId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ReportId",
                table: "Students",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Reports_ReportId",
                table: "Students",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
