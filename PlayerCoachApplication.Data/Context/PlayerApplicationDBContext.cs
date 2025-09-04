using Microsoft.EntityFrameworkCore;
using PlayerCoachApplication.Data.Context;
using PlayerCoachApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCoachApplication.Data.Context
{
    public class PlayerApplicationDBContext : DbContext
    {
        public PlayerApplicationDBContext()
        {
          
        }

        public PlayerApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SelectedPositionToSportModel> SelectedPositionToSport { get; set; }
        public DbSet<CoachApplicationModel> CoachApplicationModel { get; set; }

        public DbSet<PlayerApplicationModel> PlayerApplicationModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SelectedPositionToSportModel>()
                .HasKey(sp => new { sp.Position, sp.Sport });

            modelBuilder.Entity<CoachApplicationModel>()
                .HasKey(c => c.Id);
        }

    }
}

//This code defines a database context class called PlayerApplicationDBContext for your web app using Entity Framework Core.
//What it does:
//•	Inherits from DbContext, which is used to interact with the database.
//•	Has three properties (DbSets) that represent tables in the database:
//•	SelectedPositionToSport: Stores positions available for each sport.
//•	CoachApplicationModel: Stores coach applications.
//•	PlayerApplicationModel: Stores player applications.
//•	The constructor allows configuration of the context, such as connecting to the database.
//•	The OnModelCreating method sets up rules for the database:
//•	Makes a composite key for SelectedPositionToSportModel using both Position and Sport.
//•	Sets the primary key for CoachApplicationModel to Id.
//In short:
//This class manages how your app connects to and works with the database tables for player applications, coach applications, and sport positions.

