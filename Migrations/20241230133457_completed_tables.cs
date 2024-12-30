using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_IMR.Migrations
{
    public partial class completed_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BSMIMRBOM001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRBOM001", x => x.DOCTYPE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRBOMCONTENT",
                columns: table => new
                {
                    CONTENTNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BOMDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    BOMDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMPONENT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMPBOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMPBOMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    QUANTITY = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRBOMCONTENT", x => x.CONTENTNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRBOMHEAD",
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
                    ISDELETED = table.Column<bool>(type: "bit", nullable: true),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true),
                    DRAWNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRBOMHEAD", x => x.BOMDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRCCM001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRCCM001", x => x.DOCTYPE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRCCMHEAD",
                columns: table => new
                {
                    CCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    CCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MAINCCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MAINCCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: true),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRCCMHEAD", x => x.CCMDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRCCMTEXT",
                columns: table => new
                {
                    CCMSTEXT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CCMDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    CCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CCMLTEXT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRCCMTEXT", x => x.CCMSTEXT);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRGEN001",
                columns: table => new
                {
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMTEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ADDRESS1 = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ADDRESS2 = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    CITYCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    COUNTRYCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRGEN001", x => x.COMCODE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRGEN002",
                columns: table => new
                {
                    LANCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    LANTEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRGEN002", x => x.LANCODE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRGEN003",
                columns: table => new
                {
                    COUNTRYCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COUNTRYTEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRGEN003", x => x.COUNTRYCODE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRGEN004",
                columns: table => new
                {
                    CITYCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CITYTEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    COUNTRYCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRGEN004", x => x.CITYCODE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRGEN005",
                columns: table => new
                {
                    UNITCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    UNITTEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISMAINUNIT = table.Column<bool>(type: "bit", nullable: true),
                    MAINUNITCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRGEN005", x => x.UNITCODE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRMAT001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRMAT001", x => x.DOCTYPE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRMATHEAD",
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
                    NWUNIT = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    BRUTWEIGHT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BWUNIT = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ISBOM = table.Column<bool>(type: "bit", nullable: true),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ISROUTE = table.Column<bool>(type: "bit", nullable: true),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: true),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRMATHEAD", x => x.MATDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRMATTEXT",
                columns: table => new
                {
                    MATSTEXT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MATDOCFROM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MATDOCUNTIL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MATLTEXT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRMATTEXT", x => x.MATSTEXT);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMROPR001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMROPR001", x => x.DOCTYPE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRROT001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRROT001", x => x.DOCTYPE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRROTBOMCONTENT",
                columns: table => new
                {
                    CONTENTNUM = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ROTDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    ROTDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OPRNUM = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMPONENT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    QUANTITY = table.Column<decimal>(type: "decimal(18,2)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRROTBOMCONTENT", x => x.CONTENTNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRROTHEAD",
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
                    ISDELETED = table.Column<bool>(type: "bit", nullable: true),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true),
                    DRAWNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRROTHEAD", x => x.ROTDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRROTOPRCONTENT",
                columns: table => new
                {
                    OPRNUM = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ROTDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    ROTDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    OPRDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    SETUPTIME = table.Column<decimal>(type: "decimal(18,2)", maxLength: 3, nullable: true),
                    MACHINETIME = table.Column<decimal>(type: "decimal(18,2)", maxLength: 3, nullable: true),
                    LABOURTIME = table.Column<decimal>(type: "decimal(18,2)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRROTOPRCONTENT", x => x.OPRNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRWCM001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRWCM001", x => x.DOCTYPE);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRWCMHEAD",
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
                    WORKTIME = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ISDELETED = table.Column<bool>(type: "bit", nullable: true),
                    ISPASSIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRWCMHEAD", x => x.WCMDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRWCMOPR",
                columns: table => new
                {
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    WCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    OPRDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRWCMOPR", x => x.WCMDOCNUM);
                });

            migrationBuilder.CreateTable(
                name: "BSMIMRWCMTEXT",
                columns: table => new
                {
                    WCMSTEXT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WCMDOCFROM = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    WCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    WCMLTEXT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMIMRWCMTEXT", x => x.WCMSTEXT);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BSMIMRBOM001");

            migrationBuilder.DropTable(
                name: "BSMIMRBOMCONTENT");

            migrationBuilder.DropTable(
                name: "BSMIMRBOMHEAD");

            migrationBuilder.DropTable(
                name: "BSMIMRCCM001");

            migrationBuilder.DropTable(
                name: "BSMIMRCCMHEAD");

            migrationBuilder.DropTable(
                name: "BSMIMRCCMTEXT");

            migrationBuilder.DropTable(
                name: "BSMIMRGEN001");

            migrationBuilder.DropTable(
                name: "BSMIMRGEN002");

            migrationBuilder.DropTable(
                name: "BSMIMRGEN003");

            migrationBuilder.DropTable(
                name: "BSMIMRGEN004");

            migrationBuilder.DropTable(
                name: "BSMIMRGEN005");

            migrationBuilder.DropTable(
                name: "BSMIMRMAT001");

            migrationBuilder.DropTable(
                name: "BSMIMRMATHEAD");

            migrationBuilder.DropTable(
                name: "BSMIMRMATTEXT");

            migrationBuilder.DropTable(
                name: "BSMIMROPR001");

            migrationBuilder.DropTable(
                name: "BSMIMRROT001");

            migrationBuilder.DropTable(
                name: "BSMIMRROTBOMCONTENT");

            migrationBuilder.DropTable(
                name: "BSMIMRROTHEAD");

            migrationBuilder.DropTable(
                name: "BSMIMRROTOPRCONTENT");

            migrationBuilder.DropTable(
                name: "BSMIMRWCM001");

            migrationBuilder.DropTable(
                name: "BSMIMRWCMHEAD");

            migrationBuilder.DropTable(
                name: "BSMIMRWCMOPR");

            migrationBuilder.DropTable(
                name: "BSMIMRWCMTEXT");
        }
    }
}
