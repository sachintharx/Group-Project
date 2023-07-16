using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hos_01.Migrations
{
    /// <inheritdoc />
    public partial class Third3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LongTermDieseas",
                table: "patients",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongTermDieseas",
                table: "patients");
        }
    }
}
