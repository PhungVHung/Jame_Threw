using Microsoft.EntityFrameworkCore.Migrations;

namespace J4.Data.Migrations
{
    public partial class Details_New1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Recipe_image",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_image2",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_image3",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_image4",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_image5",
                table: "Recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recipe_image",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_image2",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_image3",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_image4",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_image5",
                table: "Recipes");
        }
    }
}
