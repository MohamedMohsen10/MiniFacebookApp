using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniFacebook.Migrations
{
    public partial class UserRole1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "UserState",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "UserRole",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserState",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserRole",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
