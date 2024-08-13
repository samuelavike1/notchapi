using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notchapi.Migrations
{
    /// <inheritdoc />
    public partial class AddTimestampsToStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "indexNumber",
                table: "Students",
                newName: "IndexNumber");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Students",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "course",
                table: "Students",
                newName: "Course");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "IndexNumber",
                table: "Students",
                newName: "indexNumber");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Students",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Course",
                table: "Students",
                newName: "course");
        }
    }
}
