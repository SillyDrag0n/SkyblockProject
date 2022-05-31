using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyblockProject.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fk_CollectionGroup",
                table: "Collection",
                newName: "Fk_CollectionGroup");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Collection",
                newName: "CollectionNeededExp");

            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "Collection",
                newName: "CollectionLevel");

            migrationBuilder.AlterColumn<int>(
                name: "Fk_CollectionGroup",
                table: "Collection",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollectionUnlock",
                table: "Collection",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionUnlock",
                table: "Collection");

            migrationBuilder.RenameColumn(
                name: "Fk_CollectionGroup",
                table: "Collection",
                newName: "fk_CollectionGroup");

            migrationBuilder.RenameColumn(
                name: "CollectionNeededExp",
                table: "Collection",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "CollectionLevel",
                table: "Collection",
                newName: "Experience");

            migrationBuilder.AlterColumn<string>(
                name: "fk_CollectionGroup",
                table: "Collection",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
