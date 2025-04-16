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
    public class GuildConfiguration : IEntityTypeConfiguration<Guild>
    {
        public void Configure(EntityTypeBuilder<Guild> builder)
        {
            builder.HasKey(g => g.Id);

            builder.HasIndex(g => g.SbiId).IsUnique();

            builder.Property(g => g.Name).IsRequired();
            builder.Property(g => g.SbiId).IsRequired();

            builder.HasOne(g => g.Founder)
                .WithMany()
                .HasForeignKey(g => g.FounderId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(g => g.Alliance)
                .WithMany(a => a.AllianceGuilds)
                .HasForeignKey(g => g.AllianceId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
