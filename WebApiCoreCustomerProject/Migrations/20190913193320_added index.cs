using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCoreCustomerProject.Migrations
{
    public partial class addedindex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IDX_Username",
                table: "Employees",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IDX_Username",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
