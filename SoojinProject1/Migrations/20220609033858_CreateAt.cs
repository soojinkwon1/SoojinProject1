using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoojinProject1.Migrations
{
    public partial class CreateAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Messages",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<int>(
                name: "DateTime",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Messages",
                newName: "Created");
        }
    }
}
