using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPage.Migrations
{
    /// <inheritdoc />
    public partial class journalDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Journals",
                type: "date",
                nullable: false,
                defaultValueSql: "CAST(GETDATE() AS DATE)",
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Journals",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "CAST(GETDATE() AS DATE)");
        }
    }
}
