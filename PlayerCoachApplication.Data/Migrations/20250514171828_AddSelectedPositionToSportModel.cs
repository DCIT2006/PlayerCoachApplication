using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerCoachApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSelectedPositionToSportModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SelectedPositionToSportModel",
                columns: table => new
                {
                    Position = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedPositionToSportModel", x => new { x.Position, x.Sport });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedPositionToSportModel");
        }
    }
}
