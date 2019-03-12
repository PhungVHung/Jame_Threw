using Microsoft.EntityFrameworkCore.Migrations;

namespace J4.Data.Migrations
{
    public partial class Resssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recipe_Step6",
                table: "Recipes",
                newName: "Step6");

            migrationBuilder.RenameColumn(
                name: "Recipe_Step5",
                table: "Recipes",
                newName: "Step5");

            migrationBuilder.RenameColumn(
                name: "Recipe_Step4",
                table: "Recipes",
                newName: "Step4");

            migrationBuilder.RenameColumn(
                name: "Recipe_Step3",
                table: "Recipes",
                newName: "Step3");

            migrationBuilder.RenameColumn(
                name: "Recipe_Step2",
                table: "Recipes",
                newName: "Step2");

            migrationBuilder.RenameColumn(
                name: "Recipe_Step1",
                table: "Recipes",
                newName: "Step1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Step6",
                table: "Recipes",
                newName: "Recipe_Step6");

            migrationBuilder.RenameColumn(
                name: "Step5",
                table: "Recipes",
                newName: "Recipe_Step5");

            migrationBuilder.RenameColumn(
                name: "Step4",
                table: "Recipes",
                newName: "Recipe_Step4");

            migrationBuilder.RenameColumn(
                name: "Step3",
                table: "Recipes",
                newName: "Recipe_Step3");

            migrationBuilder.RenameColumn(
                name: "Step2",
                table: "Recipes",
                newName: "Recipe_Step2");

            migrationBuilder.RenameColumn(
                name: "Step1",
                table: "Recipes",
                newName: "Recipe_Step1");
        }
    }
}
