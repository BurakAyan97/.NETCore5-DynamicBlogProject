using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_düzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Receiver",
                table: "Messages2s");

            migrationBuilder.DropColumn(
                name: "Sender",
                table: "Messages2s");

            migrationBuilder.AlterColumn<int>(
                name: "SenderID",
                table: "Messages2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiverID",
                table: "Messages2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SenderID",
                table: "Messages2s",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceiverID",
                table: "Messages2s",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Receiver",
                table: "Messages2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sender",
                table: "Messages2s",
                type: "int",
                nullable: true);
        }
    }
}
