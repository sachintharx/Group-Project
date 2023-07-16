using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class drugsnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Drugs",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Contity",
                table: "Drugs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contity",
                table: "Drugs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Drugs",
                newName: "name");
        }
    }
}
