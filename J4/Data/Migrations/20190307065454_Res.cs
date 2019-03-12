using Microsoft.EntityFrameworkCore.Migrations;

namespace J4.Data.Migrations
{
    public partial class Res : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Resources",
                table: "Recipes",
                newName: "Resources_prepare");

            migrationBuilder.RenameColumn(
                name: "Recipe_image",
                table: "Recipes",
                newName: "Resources7");

            migrationBuilder.RenameColumn(
                name: "Recipe_B5",
                table: "Recipes",
                newName: "Resources6");

            migrationBuilder.RenameColumn(
                name: "Recipe_B4",
                table: "Recipes",
                newName: "Resources5");

            migrationBuilder.RenameColumn(
                name: "Recipe_B3",
                table: "Recipes",
                newName: "Resources4");

            migrationBuilder.RenameColumn(
                name: "Recipe_B2",
                table: "Recipes",
                newName: "Resources3");

            migrationBuilder.RenameColumn(
                name: "Recipe",
                table: "Recipes",
                newName: "Resources2");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Recipes",
                newName: "Resources1");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Recipes",
                newName: "Recipe_image6");

            migrationBuilder.AddColumn<string>(
                name: "Image_Food",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Food",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_Step1",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_Step2",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_Step3",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_Step4",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_Step5",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_Step6",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipe_image1",
                table: "Recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image_Food",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Name_Food",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_Step1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_Step2",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_Step3",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_Step4",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_Step5",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_Step6",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Recipe_image1",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "Resources_prepare",
                table: "Recipes",
                newName: "Resources");

            migrationBuilder.RenameColumn(
                name: "Resources7",
                table: "Recipes",
                newName: "Recipe_image");

            migrationBuilder.RenameColumn(
                name: "Resources6",
                table: "Recipes",
                newName: "Recipe_B5");

            migrationBuilder.RenameColumn(
                name: "Resources5",
                table: "Recipes",
                newName: "Recipe_B4");

            migrationBuilder.RenameColumn(
                name: "Resources4",
                table: "Recipes",
                newName: "Recipe_B3");

            migrationBuilder.RenameColumn(
                name: "Resources3",
                table: "Recipes",
                newName: "Recipe_B2");

            migrationBuilder.RenameColumn(
                name: "Resources2",
                table: "Recipes",
                newName: "Recipe");

            migrationBuilder.RenameColumn(
                name: "Resources1",
                table: "Recipes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Recipe_image6",
                table: "Recipes",
                newName: "Image");
        }
    }
}
