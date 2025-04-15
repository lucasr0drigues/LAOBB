using LAOBB.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Domain.Entities
{
    public class GuildBattle : EntityBase
    {
        public Guid BattleId { get; private set; }
        public Battle Battle { get; private set; }
        public Guid GuildId { get; private set; }
        public string SbiGuildId { get; private set; }
        public string Name { get; private set; }
        public Guild Guild { get; private set; }
        public int? Kills { get; private set; }
        public int? Deaths { get; private set; }
        public int? KillFame { get; private set; }
        public Guid? AllianceId { get; private set; }
        public string? AllianceTag { get; private set; }
        public string? SbiAllianceId { get; private set; }
        public Alliance? Alliance { get; private set; }

        public GuildBattle(
            Guild guild,
            int? kills,
            int? deaths,
            int? killFame,
            Alliance? alliance,
            Battle battle)
        {
            GuildId = guild.Id;
            SbiGuildId = guild.SbiId;
            Name = guild.Name;
            Guild = guild;
            Kills = kills;
            Deaths = deaths;
            KillFame = killFame;
            AllianceId = alliance?.Id;
            AllianceTag = alliance?.AllianceTag;
            SbiAllianceId = alliance?.SbiAllianceId;
            Alliance = alliance;
            BattleId = battle.Id;
            Battle = battle;
        }
    }
}
