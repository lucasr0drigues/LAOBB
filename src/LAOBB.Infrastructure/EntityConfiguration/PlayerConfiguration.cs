using LAOBB.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Infrastructure.EntityConfiguration
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.SbiId).IsUnique(false);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.SbiId).IsRequired();

            builder.HasOne(p => p.Guild)
                .WithMany()
                .HasForeignKey(p => p.GuildId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(p => p.Alliance)
                .WithMany()
                .HasForeignKey(p => p.AllianceId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
