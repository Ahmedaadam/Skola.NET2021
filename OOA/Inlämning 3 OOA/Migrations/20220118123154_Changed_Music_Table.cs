using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning3_OOA.Migrations
{
    public partial class Changed_Music_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Artists",
                newName: "ArtistID");

            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "ArtistID",
                table: "Artists",
                newName: "ID");
        }
    }
}
