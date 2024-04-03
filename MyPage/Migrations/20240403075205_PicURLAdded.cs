using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPage.Migrations
{
    /// <inheritdoc />
    public partial class PicURLAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicURL",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicURL",
                table: "Students");
        }
    }
}
