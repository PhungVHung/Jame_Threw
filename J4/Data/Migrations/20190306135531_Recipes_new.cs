using Microsoft.EntityFrameworkCore.Migrations;

namespace J4.Data.Migrations
{
    public partial class Recipes_new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recipe",
                table: "Recipes",
                newName: "Recipe_B5");

            migrationBuilder.AddColumn<string>(
                name: "Image_Practice2",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image_Practice3",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_B1",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_B2",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_B3",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_B4",
                table: "Recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image_Practice2",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Image_Practice3",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_B1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_B2",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_B3",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_B4",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "Recipe_B5",
                table: "Recipes",
                newName: "Recipe");
        }
    }
}
