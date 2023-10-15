using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mf.Migrations
{
    /// <inheritdoc />
    public partial class newInputPreferendGenders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreferendGender",
                table: "AbpUsers",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreferendGender",
                table: "AbpUsers");
        }
    }
}
