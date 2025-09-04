using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using PlayerCoachApplication.Data.Models;

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

//This code defines a database migration that creates a new table called SelectedPositionToSportModel.
//What it does:
//•	In the Up method (when applying the migration):
//•	Creates the SelectedPositionToSportModel table with two columns:
//•	Position(string, cannot be null)
//•	Sport(string, cannot be null)
//•	Sets a composite primary key using both Position and Sport. This means each combination of position and sport must be unique.
//•	In the Down method (when rolling back the migration):
//•	Deletes the SelectedPositionToSportModel table.
//In short:
//This migration adds a table to store which positions are available for each sport, ensuring no duplicate position-sport pairs.
