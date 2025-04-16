using LAOBB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Infrastructure.EntityConfiguration
{
    public class GuildBattleConfiguration : IEntityTypeConfiguration<GuildBattle>
    {
        public void Configure(EntityTypeBuilder<GuildBattle> builder)
        {
            builder.HasKey(gb => gb.Id);

            builder.HasOne(gb => gb.Guild)
                .WithMany()
                .HasForeignKey(gb => gb.GuildId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(gb => gb.Battle)
                .WithMany(b => b.GuildBattles)
                .HasForeignKey(gb => gb.BattleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(gb => gb.Alliance)
                .WithMany()
                .HasForeignKey(gb => gb.AllianceId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
