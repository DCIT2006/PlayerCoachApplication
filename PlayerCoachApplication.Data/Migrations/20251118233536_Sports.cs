using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerCoachApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class Sports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoachApplicationModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: true),
                    SelectedSportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachApplicationModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerApplicationModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PreferredPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedSportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerApplicationModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelectedPositionToSport",
                columns: table => new
                {
                    Position = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedPositionToSport", x => new { x.Position, x.Sport });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachApplicationModel");

            migrationBuilder.DropTable(
                name: "PlayerApplicationModel");

            migrationBuilder.DropTable(
                name: "SelectedPositionToSport");
        }
    }
}
