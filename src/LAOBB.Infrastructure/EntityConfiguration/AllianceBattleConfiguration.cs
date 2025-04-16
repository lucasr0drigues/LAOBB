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
    public class AllianceBattleConfiguration : IEntityTypeConfiguration<AllianceBattle>
    {
        public void Configure(EntityTypeBuilder<AllianceBattle> builder)
        {
            builder.HasKey(ab => ab.Id);

            builder.HasOne(ab => ab.Alliance)
                .WithMany()
                .HasForeignKey(ab => ab.AllianceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ab => ab.Battle)
                .WithMany(b => b.AllianceBattles)
                .HasForeignKey(ab => ab.BattleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
