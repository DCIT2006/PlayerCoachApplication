using Microsoft.EntityFrameworkCore;
using PlayerCoachApplication.Data.Context;
using PlayerCoachApplication.Data.Models;

public class CoachSeeder
{
    private readonly PlayerApplicationDBContext _context;
    public CoachSeeder(PlayerApplicationDBContext context)
    {
        _context = context;
    }
    public async Task SeedASync()
    {      
        await _context.Database.MigrateAsync();

        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            if (!await _context.SelectedPositionToSport.AnyAsync())
            {
              _context.SelectedPositionToSport.AddRange(new SelectedPositionToSportModel
                {
                    Sport = "Soccer",
                    Position = "Goalkeeper"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Soccer",
                    Position = "Defender"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Soccer",
                    Position = "Midfielder"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Soccer",
                    Position = "Forward"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Basketball",
                    Position = "Point Guard"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Basketball",
                    Position = "Shooting Guard"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Basketball",
                    Position = "Small Forward"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Basketball",
                    Position = "Power Forward"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Basketball",
                    Position = "Center"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Quarterback"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Running Back"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Wide Receiver"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Tight End"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Linebacker"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Defensive Back"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Offensive Lineman"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Defensive Lineman"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Kicker"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Football",
                    Position = "Punter"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Hockey",
                    Position = "Center"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Hockey",
                    Position = "Left Wing"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Hockey",
                    Position = "Right Wing"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Hockey",
                    Position = "Defenseman"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Hockey",
                    Position = "Goaltender"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "Pitcher"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "Catcher"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "First Baseman"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "Second Baseman"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "Third Baseman"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "Shortstop"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "Left Fielder"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "Center Fielder"
                },
                new SelectedPositionToSportModel
                {
                    Sport = "Baseball",
                    Position = "Right Fielder"
                });
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            await transaction.RollbackAsync();
        }
    }

    
}