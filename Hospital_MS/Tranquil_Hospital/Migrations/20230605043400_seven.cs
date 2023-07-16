using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class seven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_patients",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctors",
                table: "doctors");

            migrationBuilder.RenameTable(
                name: "patients",
                newName: "Dbpatients");

            migrationBuilder.RenameTable(
                name: "doctors",
                newName: "Dbdoctors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dbpatients",
                table: "Dbpatients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dbdoctors",
                table: "Dbdoctors",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dbpatients",
                table: "Dbpatients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dbdoctors",
                table: "Dbdoctors");

            migrationBuilder.RenameTable(
                name: "Dbpatients",
                newName: "patients");

            migrationBuilder.RenameTable(
                name: "Dbdoctors",
                newName: "doctors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_patients",
                table: "patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctors",
                table: "doctors",
                column: "Id");
        }
    }
}
