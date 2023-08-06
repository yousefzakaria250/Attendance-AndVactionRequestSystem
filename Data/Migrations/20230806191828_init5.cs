using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employee_SupervisiorId",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SupervisiorId",
                table: "Employee",
                type: "int",
                nullable: true,
                defaultValue: null,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employee_SupervisiorId",
                table: "Employee",
                column: "SupervisiorId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employee_SupervisiorId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Request");

            migrationBuilder.AlterColumn<int>(
                name: "SupervisiorId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employee_SupervisiorId",
                table: "Employee",
                column: "SupervisiorId",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
