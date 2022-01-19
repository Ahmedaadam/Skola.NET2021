using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning3_OOA.Migrations
{
    public partial class Update_table13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistMusic_Artists_ArtistsArtistID",
                table: "ArtistMusic");

            migrationBuilder.RenameColumn(
                name: "ArtistID",
                table: "Artists",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ArtistsArtistID",
                table: "ArtistMusic",
                newName: "ArtistsID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistMusic_Artists_ArtistsID",
                table: "ArtistMusic",
                column: "ArtistsID",
                principalTable: "Artists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistMusic_Artists_ArtistsID",
                table: "ArtistMusic");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Artists",
                newName: "ArtistID");

            migrationBuilder.RenameColumn(
                name: "ArtistsID",
                table: "ArtistMusic",
                newName: "ArtistsArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistMusic_Artists_ArtistsArtistID",
                table: "ArtistMusic",
                column: "ArtistsArtistID",
                principalTable: "Artists",
                principalColumn: "ArtistID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
