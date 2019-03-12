using Microsoft.EntityFrameworkCore.Migrations;

namespace J4.Data.Migrations
{
    public partial class database_new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image_Practice",
                table: "Recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image_Practice",
                table: "Recipes");
        }
    }
}
