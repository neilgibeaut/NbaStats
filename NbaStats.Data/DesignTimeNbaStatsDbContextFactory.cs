using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaStats.Data
{
    public class DesignTimeNbaStatsDbContextFactory : IDesignTimeDbContextFactory<NbaStatsDbContext>
    {
        public NbaStatsDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<NbaStatsDbContext>();
            
            var defaultConnectionString =
                "Server=localhost;Database=NbaStats;Trusted_Connection=true;MultipleActiveResultSets=true;";
            
            options.UseSqlServer(defaultConnectionString);

            return new NbaStatsDbContext(options.Options);
        }
    }
}
