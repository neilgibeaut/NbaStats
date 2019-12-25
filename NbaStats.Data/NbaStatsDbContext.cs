using Microsoft.EntityFrameworkCore;
using NbaStats.Data.Config.SeedData;
using NbaStats.Domain.Games.State;
using NbaStats.Domain.Teams.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaStats.Data
{
    public class NbaStatsDbContext: DbContext
    {
        public NbaStatsDbContext(DbContextOptions<NbaStatsDbContext> options): base(options) {}
        public DbSet<Game> Games { get; set; }

        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add Configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NbaStatsDbContext).Assembly);
            // Add seed data
            modelBuilder.AddTeamData();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var defaultConnectionString =
                "Server=localhost;Database=NbaStats;Trusted_Connection=true;MultipleActiveResultSets=true;";
            options.UseSqlServer(defaultConnectionString);
        }
    }
}
