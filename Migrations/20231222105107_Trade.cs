using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_TUTORIAL_5_12_23.Migrations
{
    public partial class Trade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Traderecords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    INDEX = table.Column<int>(type: "int", nullable: false),
                    PRICE = table.Column<int>(type: "int", nullable: false),
                    BORS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SL = table.Column<int>(type: "int", nullable: false),
                    PROFIT = table.Column<int>(type: "int", nullable: false),
                    TOTAL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traderecords", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traderecords");
        }
    }
}
