using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dangnhapvadangsuat.Migrations
{
    /// <inheritdoc />
    public partial class DateOfBirthAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfbirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfbirth",
                table: "AspNetUsers");
        }
    }
}
