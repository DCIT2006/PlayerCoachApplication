using Microsoft.EntityFrameworkCore;
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
