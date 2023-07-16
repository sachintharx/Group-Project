using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class adss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "patientDoctords");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "patientDoctords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
