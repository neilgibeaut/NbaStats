using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NbaStats.Domain.Games.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaStats.Data.Config
{
    class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasOne(e => e.HomeTeam)
               .WithMany()
               .HasForeignKey(e => e.HomeTeamName);

            builder.HasOne(e => e.AwayTeam)
                .WithMany()
                .HasForeignKey(e => e.AwayTeamName); 
        }
    }
}
