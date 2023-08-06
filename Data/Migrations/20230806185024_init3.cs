using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employee_SupervisiorId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_SupervisiorId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SupervisiorId",
                table: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupervisiorId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SupervisiorId",
                table: "Employee",
                column: "SupervisiorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employee_SupervisiorId",
                table: "Employee",
                column: "SupervisiorId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
