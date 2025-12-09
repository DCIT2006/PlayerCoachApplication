using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlayerCoachApplication.Data.Context;

Console.WriteLine("Seeding database...");
// Build Configuration
Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
Console.WriteLine($"Base Directory: {AppDomain.CurrentDomain.BaseDirectory}");
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<PlayerApplicationDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddTransient<CoachSeeder>();
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
  
    var seeder = scope.ServiceProvider.GetRequiredService<CoachSeeder>();
    await seeder.SeedASync();
}