using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InleveropdrGijs.Migrations
{
    public partial class InleveropdrGijs1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            


            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    klantNaam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AantalVrienden = table.Column<int>(type: "int", nullable: false),
                    Punten = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    FotoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AantalFotos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.FotoID);
                });

            migrationBuilder.CreateTable(
                name: "Winkels",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prijs = table.Column<int>(type: "int", nullable: false),
                    Vooraad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winkels", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    CameraID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AantalBevestigd = table.Column<int>(type: "int", nullable: false),
                    FotoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.CameraID);
                    table.ForeignKey(
                        name: "FK_Cameras_Fotos_FotoID",
                        column: x => x.FotoID,
                        principalTable: "Fotos",
                        principalColumn: "FotoID");
                });

            migrationBuilder.CreateTable(
                name: "Locaties",
                columns: table => new
                {
                    LocatieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plaats = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CameraID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locaties", x => x.LocatieID);
                    table.ForeignKey(
                        name: "FK_Locaties_Cameras_CameraID",
                        column: x => x.CameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_FotoID",
                table: "Cameras",
                column: "FotoID");

            migrationBuilder.CreateIndex(
                name: "IX_Locaties_CameraID",
                table: "Locaties",
                column: "CameraID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Locaties");

            migrationBuilder.DropTable(
                name: "Winkels");

            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "Fotos");
        }
    }
}
