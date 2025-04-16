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
    public class PlayerBattleConfiguratio : IEntityTypeConfiguration<PlayerBattle>
    {
        public void Configure(EntityTypeBuilder<PlayerBattle> builder)
        {
            builder.HasKey(pb => pb.Id);

            builder.HasOne(pb => pb.Player)
                .WithMany()
                .HasForeignKey(pb => pb.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pb => pb.Battle)
                .WithMany(b => b.PlayerBattles)
                .HasForeignKey(pb => pb.BattleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pb => pb.Guild)
                .WithMany()
                .HasForeignKey(pb => pb.GuildId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(pb => pb.Alliance)
                .WithMany()
                .HasForeignKey(pb => pb.AllianceId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
