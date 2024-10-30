using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab2_ORM_part2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherNomer",
                table: "Person",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentNomer",
                table: "Person",
                newName: "StudentId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateBirth",
                table: "Person",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Person",
                newName: "TeacherNomer");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Person",
                newName: "StudentNomer");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateBirth",
                table: "Person",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }
    }
}
