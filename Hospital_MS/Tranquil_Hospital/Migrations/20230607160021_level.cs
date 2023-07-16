using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class level : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId1",
                table: "Dbdoctors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dbdoctors_PatientId1",
                table: "Dbdoctors",
                column: "PatientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Dbdoctors_Dbpatients_PatientId1",
                table: "Dbdoctors",
                column: "PatientId1",
                principalTable: "Dbpatients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dbdoctors_Dbpatients_PatientId1",
                table: "Dbdoctors");

            migrationBuilder.DropIndex(
                name: "IX_Dbdoctors_PatientId1",
                table: "Dbdoctors");

            migrationBuilder.DropColumn(
                name: "PatientId1",
                table: "Dbdoctors");
        }
    }
}
