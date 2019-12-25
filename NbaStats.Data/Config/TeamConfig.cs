using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NbaStats.Domain.Teams.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaStats.Data.Config
{
    class TeamConfig: IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.Name);
        }
    }
}
