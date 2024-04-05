using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPage.Migrations
{
    /// <inheritdoc />
    public partial class BookCover : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookImgCover",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookImgCover",
                table: "Books");
        }
    }
}
