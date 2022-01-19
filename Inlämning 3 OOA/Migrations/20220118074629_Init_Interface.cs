using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning3_OOA.Migrations
{
    public partial class Init_Interface : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Songs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.RenameTable(
                name: "Songs",
                newName: "People");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "ID");
        }
    }
}
