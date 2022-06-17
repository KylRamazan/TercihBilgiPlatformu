using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class sayfa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Sayfas");

            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "Sayfas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ControllerAdi",
                table: "Sayfas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViewAdi",
                table: "Sayfas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControllerAdi",
                table: "Sayfas");

            migrationBuilder.DropColumn(
                name: "ViewAdi",
                table: "Sayfas");

            migrationBuilder.AlterColumn<int>(
                name: "Adi",
                table: "Sayfas",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Url",
                table: "Sayfas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
