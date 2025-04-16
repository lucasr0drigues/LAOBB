using LAOBB.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Domain.Entities
{
    public class AllianceBattle : EntityBase
    {
        public Guid BattleId { get; private set; }
        public Battle Battle { get; private set; }
        public Guid AllianceId { get; private set; }
        public string SbiAllianceId { get; private set; }
        public string AllianceTag { get; private set; }
        public Alliance Alliance { get; private set; }
        public int? Kills { get; private set; }
        public int? Deaths { get; private set; }
        public int? KillFame { get; private set; }

        protected AllianceBattle() { }

        public AllianceBattle(
            Battle battle,
            Alliance alliance,
            int? kills,
            int? deaths,
            int? killFame)
        {
            BattleId = battle.Id;
            Battle = battle;
            AllianceId = alliance.Id;
            SbiAllianceId = alliance.SbiAllianceId;
            AllianceTag = alliance.AllianceTag;
            Alliance = alliance;
            Kills = kills;
            Deaths = deaths;
            KillFame = killFame;
        }
    }
}
