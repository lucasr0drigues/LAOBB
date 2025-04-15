using LAOBB.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Domain.Entities
{
    public class PlayerBattle : EntityBase
    {
        public Guid BattleId { get; private set; }
        public Battle Battle { get; private set; }
        public Guid PlayerId { get; private set; }
        public string? SbiPlayerId { get; private set; }
        public string PlayerName { get; private set; }
        public Player Player { get; private set; }
        public int? Kills { get; private set; }
        public int? Deaths { get; private set; }
        public int? KillFame { get; private set; }
        public Guid? GuildId { get; private set; }
        public string? GuildName { get; private set; }
        public string? SbiGuildId { get; private set; }
        public Guild? Guild { get; private set; }
        public Guid? AllianceId { get; private set; }
        public string? AllianceTag { get; private set; }
        public string? SbiAllianceId { get; private set; }
        public Alliance? Alliance { get; private set; }

        public PlayerBattle(
            Player player,
            int? kills,
            int? deaths,
            int? killFame,
            Guild? guild,
            Alliance? alliance,
            Battle battle)
        {
            PlayerId = player.Id;
            SbiPlayerId = player.SbiId;
            PlayerName = player.Name;
            Player = player;
            Kills = kills;
            Deaths = deaths;
            KillFame = killFame;
            GuildId = guild?.Id;
            GuildName = guild?.Name;
            SbiGuildId = guild?.SbiId;
            Guild = guild;
            AllianceId = alliance?.Id;
            AllianceTag = alliance?.AllianceTag;
            SbiAllianceId = alliance?.SbiAllianceId;
            Alliance = alliance;
            BattleId = battle.Id;
            Battle = battle;
        }
    }
}
