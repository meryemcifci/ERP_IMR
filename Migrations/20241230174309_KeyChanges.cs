using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_IMR.Migrations
{
    public partial class KeyChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BSMIMRWCMOPR",
                table: "BSMIMRWCMOPR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BSMIMRWCMOPR",
                table: "BSMIMRWCMOPR",
                column: "OPRDOCTYPE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BSMIMRWCMOPR",
                table: "BSMIMRWCMOPR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BSMIMRWCMOPR",
                table: "BSMIMRWCMOPR",
                column: "WCMDOCNUM");
        }
    }
}
