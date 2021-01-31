using Microsoft.EntityFrameworkCore.Migrations;

namespace LibrarySystem.Api.Migrations
{
    public partial class Edit_Enities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainCategory",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubCategory",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainCategory",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "SubCategory",
                table: "Books");
        }
    }
}
