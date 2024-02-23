using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Villas",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Villas",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Villas",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Villas",
                newName: "ID");
        }
    }
}
