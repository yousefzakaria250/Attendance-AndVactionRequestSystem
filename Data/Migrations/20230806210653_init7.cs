using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Request",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Request_DepartmentId",
                table: "Request",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Department_DepartmentId",
                table: "Request",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Department_DepartmentId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_DepartmentId",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Request");
        }
    }
}
