using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace J4.Data.Migrations
{
    public partial class Jamethreww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contests");

            migrationBuilder.CreateTable(
                name: "Announcenment",
                columns: table => new
                {
                    Id_announ = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tittle_announ = table.Column<string>(nullable: true),
                    Describle_announ = table.Column<string>(nullable: true),
                    Image_announ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcenment", x => x.Id_announ);
                });

            migrationBuilder.CreateTable(
                name: "Contest",
                columns: table => new
                {
                    Id_contest = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name_contest = table.Column<string>(nullable: true),
                    Img_contest = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    Describle = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contest", x => x.Id_contest);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcenment");

            migrationBuilder.DropTable(
                name: "Contest");

            migrationBuilder.CreateTable(
                name: "Contests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Describle = table.Column<string>(nullable: true),
                    LinkRegis = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UrlVideo = table.Column<string>(nullable: true),
                    role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contests", x => x.Id);
                });
        }
    }
}
