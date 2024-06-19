using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPage.Migrations
{
    /// <inheritdoc />
    public partial class todoss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "ToDos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDone",
                table: "ToDos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "isDone",
                table: "ToDos");
        }
    }
}
