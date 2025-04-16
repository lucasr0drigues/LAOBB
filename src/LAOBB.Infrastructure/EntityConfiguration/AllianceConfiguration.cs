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
    public class AllianceConfiguration : IEntityTypeConfiguration<Alliance>
    {
        public void Configure(EntityTypeBuilder<Alliance> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasIndex(a => a.SbiAllianceId).IsUnique();

            builder.Property(a => a.SbiAllianceId).IsRequired();
            builder.Property(a => a.AllianceName).IsRequired();
            builder.Property(a => a.AllianceTag).IsRequired();

            builder.HasOne(a => a.Founder)
                .WithMany()
                .HasForeignKey(a => a.FounderId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
