using Microsoft.EntityFrameworkCore;
using NbaStats.Domain.Teams.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaStats.Data.Config.SeedData
{
    public static class TeamData
    {
        public static void AddTeamData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new { Name = "Atlanta Hawks" },
                new { Name = "Boston Celtics" },
                new { Name = "Brooklyn Nets" },
                new { Name = "Charlotte Hornets" },
                new { Name = "Chicago Bulls" },
                new { Name = "Cleveland Cavaliers" },
                new { Name = "Dallas Mavericks" },
                new { Name = "Denver Nuggers" },
                new { Name = "Detroit Pistons" },
                new { Name = "Golden State Warriors" },
                new { Name = "Houston Rockets" },
                new { Name = "Indiana Pacers" },
                new { Name = "Los Angeles Clippers" },
                new { Name = "Los Angeles Lakers" },
                new { Name = "Memphis Grizzlies" },
                new { Name = "Miami Heat" },
                new { Name = "Milwaukee Bucks" },
                new { Name = "Minnesota Timberwolves" },
                new { Name = "New Orleans Pelicans" },
                new { Name = "New York Knicks" },
                new { Name = "Oklahoma City Thunder" },
                new { Name = "Orlando Magic" },
                new { Name = "Philadelphia 76ers" },
                new { Name = "Phoenix Suns" },
                new { Name = "Portland Trail Blazers" },
                new { Name = "Sacramento Kings" },
                new { Name = "San Antonio Spurs" },
                new { Name = "Toronto Raptors" },
                new { Name = "Utah Jazz" },
                new { Name = "Washington Wizards" }
                );
        }
    }
}
