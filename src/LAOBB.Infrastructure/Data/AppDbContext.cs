using LAOBB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Player> Players => Set<Player>();
        public DbSet<Alliance> Alliances => Set<Alliance>();
        public DbSet<Guild> Guilds => Set<Guild>();
        public DbSet<Battle> Battles => Set<Battle>();
        public DbSet<PlayerBattle> PlayerBattles => Set<PlayerBattle>();
        public DbSet<AllianceBattle> AllianceBattles => Set<AllianceBattle>();
        public DbSet<GuildBattle> GuildBattles => Set<GuildBattle>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
