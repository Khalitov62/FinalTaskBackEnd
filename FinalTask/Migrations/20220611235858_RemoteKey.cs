using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalTask.Migrations
{
    public partial class RemoteKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "Statics");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Statics");

            migrationBuilder.AddColumn<string>(
                name: "Volume",
                table: "Statics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Statics");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Statics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Statics",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
