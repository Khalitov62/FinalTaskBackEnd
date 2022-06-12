using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalTask.Migrations
{
    public partial class changeSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Statics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Statics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Width",
                table: "Statics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Statics");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Statics");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Statics");
        }
    }
}
