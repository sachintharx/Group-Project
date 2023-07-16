using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class chanuka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "patientDrugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientID = table.Column<int>(type: "INTEGER", nullable: false),
                    DrugsID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientDrugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patientDrugs_Dbpatients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Dbpatients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_patientDrugs_Drugs_DrugsID",
                        column: x => x.DrugsID,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_patientDrugs_DrugsID",
                table: "patientDrugs",
                column: "DrugsID");

            migrationBuilder.CreateIndex(
                name: "IX_patientDrugs_PatientID",
                table: "patientDrugs",
                column: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "patientDrugs");
        }
    }
}
