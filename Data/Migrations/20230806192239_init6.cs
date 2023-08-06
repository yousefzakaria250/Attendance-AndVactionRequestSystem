using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Request");

            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
