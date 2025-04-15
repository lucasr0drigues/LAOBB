using LAOBB.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Domain.Entities
{
    public class Battle : EntityBase
    {
        public int? SbiId { get; private set; }
        public string? StartTime { get; private set; }
        public string? EndTime { get; private set; }
        public string? Timeout { get; private set; }
        public int? TotalFame { get; private set; }
        public int? TotalKills { get; private set; }
        public object ClusterName { get; private set; }
        public int? BattleTimeout { get; private set; }

        public virtual IReadOnlyCollection<PlayerBattle> PlayerBattles => _playerBattles;
        private List<PlayerBattle> _playerBattles = new();

        public virtual IReadOnlyCollection<GuildBattle> GuildBattles => _guildBattles;
        private List<GuildBattle> _guildBattles = new();

        public virtual IReadOnlyCollection<AllianceBattle> AllianceBattles => _allianceBattles;
        private List<AllianceBattle> _allianceBattles = new();

        public Battle(
            int? sbiId,
            string? startTime,
            string? endTime,
            string? timeout,
            int? totalFame,
            int? totalKills,
            object clusterName,
            int? battleTimeout)
        {
            SbiId = sbiId;
            StartTime = startTime;
            EndTime = endTime;
            Timeout = timeout;
            TotalFame = totalFame;
            TotalKills = totalKills;
            ClusterName = clusterName;
            BattleTimeout = battleTimeout;
        }

        public void AddPlayerBattle(PlayerBattle playerBattle)
            => _playerBattles.Add(playerBattle);

        public void RemovePlayerBattle(PlayerBattle playerBattle)
            => _playerBattles.Remove(playerBattle);

        public void AddGuildBattle(GuildBattle guildBattle)
            => _guildBattles.Add(guildBattle);

        public void RemoveGuildBattle(GuildBattle guildBattle)
            => _guildBattles.Remove(guildBattle);

        public void AddAllianceBattle(AllianceBattle allianceBattle)
            => _allianceBattles.Add(allianceBattle);

        public void RemoveAllianceBattle(AllianceBattle allianceBattle)
            => _allianceBattles.Remove(allianceBattle);
    }
}
