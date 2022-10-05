using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InleveropdrGijs.Migrations
{
    public partial class Gijsiscool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_Fotos_FotoID",
                table: "Cameras");

            migrationBuilder.DropIndex(
                name: "IX_Cameras_FotoID",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "FotoID",
                table: "Cameras");

            migrationBuilder.AddColumn<int>(
                name: "CameraID",
                table: "Fotos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CameraFoto",
                columns: table => new
                {
                    CameraID = table.Column<int>(type: "int", nullable: false),
                    FotoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraFoto", x => new { x.CameraID, x.FotoID });
                    table.ForeignKey(
                        name: "FK_CameraFoto_Cameras_CameraID",
                        column: x => x.CameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CameraFoto_Fotos_FotoID",
                        column: x => x.FotoID,
                        principalTable: "Fotos",
                        principalColumn: "FotoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CameraFoto_FotoID",
                table: "CameraFoto",
                column: "FotoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CameraFoto");

            migrationBuilder.DropColumn(
                name: "CameraID",
                table: "Fotos");

            migrationBuilder.AddColumn<int>(
                name: "FotoID",
                table: "Cameras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_FotoID",
                table: "Cameras",
                column: "FotoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_Fotos_FotoID",
                table: "Cameras",
                column: "FotoID",
                principalTable: "Fotos",
                principalColumn: "FotoID");
        }
    }
}
