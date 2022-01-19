using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning3_OOA.Migrations
{
    public partial class Update_Table10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Artists_ArtistID",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_ArtistID",
                table: "Songs");

            migrationBuilder.CreateTable(
                name: "ArtistMusic",
                columns: table => new
                {
                    ArtistsArtistID = table.Column<int>(type: "int", nullable: false),
                    SongsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistMusic", x => new { x.ArtistsArtistID, x.SongsID });
                    table.ForeignKey(
                        name: "FK_ArtistMusic_Artists_ArtistsArtistID",
                        column: x => x.ArtistsArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistMusic_Songs_SongsID",
                        column: x => x.SongsID,
                        principalTable: "Songs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistMusic_SongsID",
                table: "ArtistMusic",
                column: "SongsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistMusic");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ArtistID",
                table: "Songs",
                column: "ArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Artists_ArtistID",
                table: "Songs",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ArtistID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
