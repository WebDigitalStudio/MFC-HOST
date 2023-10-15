using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mf.Migrations
{
    /// <inheritdoc />
    public partial class newInputs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string[]>(
                name: "Interests",
                table: "AbpUsers",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "AbpUsers",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Interests",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "AbpUsers");
        }
    }
}
