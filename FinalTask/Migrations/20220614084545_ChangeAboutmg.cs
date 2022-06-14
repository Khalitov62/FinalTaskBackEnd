using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalTask.Migrations
{
    public partial class ChangeAboutmg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UconUrl2",
                table: "AboutImgs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UconUrl3",
                table: "AboutImgs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UconUrl2",
                table: "AboutImgs");

            migrationBuilder.DropColumn(
                name: "UconUrl3",
                table: "AboutImgs");
        }
    }
}
