using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mf.Migrations
{
    /// <inheritdoc />
    public partial class newInputAge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AbpUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AbpUsers");
        }
    }
}
