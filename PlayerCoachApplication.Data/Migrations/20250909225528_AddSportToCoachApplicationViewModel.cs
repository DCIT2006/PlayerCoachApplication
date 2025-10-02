using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayerCoachApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSportToCoachApplicationViewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sport",
                table: "CoachApplicationModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sport",
                table: "CoachApplicationModel");
        }
    }
}
