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
        using var transaction = await _context.Database.BeginTransactionAsync();
    }

    
}