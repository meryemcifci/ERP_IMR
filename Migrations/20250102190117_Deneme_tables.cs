using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_IMR.Migrations
{
    public partial class Deneme_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MalzemeViewModel",
                columns: table => new
                {
                    COMCODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SUPPLYTYPE = table.Column<int>(type: "int", nullable: false),
                    STUNIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NETWEIGHT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NWUNIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BRUTWEIGHT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BWUNIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBOM = table.Column<bool>(type: "bit", nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISROUTE = table.Column<bool>(type: "bit", nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATSTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATLTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MalzemeViewModel");
        }
    }
}
