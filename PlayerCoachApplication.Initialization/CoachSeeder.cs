using Microsoft.EntityFrameworkCore;
using PlayerCoachApplication.Data.Context;

public class CoachSeeder
{
    private readonly PlayerApplicationDBContext _context;
    public CoachSeeder(PlayerApplicationDBContext context)
    {
        _context = context;
    }
    public async Task SeedASync()
    {
        await _context.Database.EnsureCreatedAsync();
        
        await _context.Database.MigrateAsync();

        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            if (await _context.CoachApplicationModel.AnyAsync())
            {
                Console.WriteLine("CoachApplicationModel has data");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            await transaction.RollbackAsync();
        }
    }

    
}