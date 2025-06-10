using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerCoachApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class Sport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SelectedPositionToSportModel",
                table: "SelectedPositionToSportModel");

            migrationBuilder.RenameTable(
                name: "SelectedPositionToSportModel",
                newName: "SelectedPositionToSport");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SelectedPositionToSport",
                table: "SelectedPositionToSport",
                columns: new[] { "Position", "Sport" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SelectedPositionToSport",
                table: "SelectedPositionToSport");

            migrationBuilder.RenameTable(
                name: "SelectedPositionToSport",
                newName: "SelectedPositionToSportModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SelectedPositionToSportModel",
                table: "SelectedPositionToSportModel",
                columns: new[] { "Position", "Sport" });
        }
    }
}
