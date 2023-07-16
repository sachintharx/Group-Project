using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class drgss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "patientDoctords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientDoctords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patientDoctords_Dbdoctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Dbdoctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_patientDoctords_Dbpatients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Dbpatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_patientDoctords_DoctorId",
                table: "patientDoctords",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_patientDoctords_PatientId",
                table: "patientDoctords",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "patientDoctords");

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
    }
}
