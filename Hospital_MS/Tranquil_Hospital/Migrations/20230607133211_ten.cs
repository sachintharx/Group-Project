using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class ten : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Dbdoctors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dbdoctors_PatientId",
                table: "Dbdoctors",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dbdoctors_Dbpatients_PatientId",
                table: "Dbdoctors",
                column: "PatientId",
                principalTable: "Dbpatients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dbdoctors_Dbpatients_PatientId",
                table: "Dbdoctors");

            migrationBuilder.DropIndex(
                name: "IX_Dbdoctors_PatientId",
                table: "Dbdoctors");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Dbdoctors");
        }
    }
}
