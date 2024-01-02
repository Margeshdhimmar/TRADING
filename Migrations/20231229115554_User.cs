using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_TUTORIAL_5_12_23.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_signInModels",
                table: "signInModels");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "signInModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "signInModels",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_signInModels",
                table: "signInModels",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_signInModels",
                table: "signInModels");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "signInModels");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "signInModels",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_signInModels",
                table: "signInModels",
                column: "Email");
        }
    }
}
