using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class Xam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Drugs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_PatientId",
                table: "Drugs",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drugs_Dbpatients_PatientId",
                table: "Drugs",
                column: "PatientId",
                principalTable: "Dbpatients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drugs_Dbpatients_PatientId",
                table: "Drugs");

            migrationBuilder.DropIndex(
                name: "IX_Drugs_PatientId",
                table: "Drugs");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Drugs");
        }
    }
}
