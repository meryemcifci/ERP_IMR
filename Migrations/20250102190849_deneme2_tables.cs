using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_IMR.Migrations
{
    public partial class deneme2_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BSMIMRBOMHEADCONTENT",
                columns: table => new
                {
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    BOMDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    QUANTITY = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: false),
                    DRAWNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CONTENTNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMPONENT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMPBOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMPBOMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRBOMHEADCONTENT", x => x.BOMDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRCCMHEADTEXT",
                columns: table => new
                {
                    CCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    CCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MAINCCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MAINCCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CCMSTEXT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CCMLTEXT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRCCMHEADTEXT", x => x.CCMDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRMATHEADTEXT",
                columns: table => new
                {
                    MATDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SUPPLYTYPE = table.Column<int>(type: "int", nullable: false),
                    STUNIT = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NETWEIGHT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NWUNIT = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    BRUTWEIGHT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BWUNIT = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ISBOM = table.Column<bool>(type: "bit", nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ISROUTE = table.Column<bool>(type: "bit", nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MATSTEXT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MATLTEXT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRMATHEADTEXT", x => x.MATDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRROTHEADCONTENT",
                columns: table => new
                {
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    ROTDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    QUANTITY = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: false),
                    DRAWNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OPRNUM = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CONTENTNUM = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    COMPONENT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OPRDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    SETUPTIME = table.Column<decimal>(type: "decimal(18,2)", maxLength: 3, nullable: false),
                    MACHINETIME = table.Column<decimal>(type: "decimal(18,2)", maxLength: 3, nullable: false),
                    LABOURTIME = table.Column<decimal>(type: "decimal(18,2)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRROTHEADCONTENT", x => x.ROTDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRWCMHEADTEXTOPR",
                columns: table => new
                {
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    WCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MAINWCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MAINWCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WORKTIME = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    WCMSTEXT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WCMLTEXT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OPRDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRWCMHEADTEXTOPR", x => x.WCMDOCNUM);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BSMIMRBOMHEADCONTENT");

            migrationBuilder.DropTable(
                name: "BSMIMRCCMHEADTEXT");

            migrationBuilder.DropTable(
                name: "BSMIMRMATHEADTEXT");

            migrationBuilder.DropTable(
                name: "BSMIMRROTHEADCONTENT");

            migrationBuilder.DropTable(
                name: "BSMIMRWCMHEADTEXTOPR");
        }
    }
}
