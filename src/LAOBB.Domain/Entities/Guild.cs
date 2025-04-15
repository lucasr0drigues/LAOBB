using LAOBB.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Domain.Entities
{
    public class Guild : EntityBase
    {
        public string SbiId { get; private set; }
        public string Name { get; private set; }
        public Guid? FounderId { get; private set; }
        public string? SbiFounderId { get; private set; }
        public string? FounderName { get; private set; }
        public Player? Founder { get; private set; }
        public DateTime Founded { get; private set; }
        public string? AllianceTag { get; private set; }
        public Guid? AllianceId { get; private set; }
        public string? SbiAllianceId { get; private set; }
        public string? AllianceName { get; private set; }
        public Alliance? Alliance { get; private set; }
        public string? Logo { get; private set; }
        public long? KillFame { get; private set; }
        public long? DeathFame { get; private set; }
        public int? AttacksWon { get; private set; }
        public int? DefensesWon { get; private set; }

        // will receive the infos about the founder as it is because the character might not exist anymore
        public Guild(
            string sbiId,
            string name,
            Guid? founderId,
            string? sbiFounderId,
            string? founderName,
            Player? founder,
            DateTime founded,
            string? allianceTag,
            Guid? allianceId,
            string? sbiAllianceId,
            string? allianceName,
            Alliance? alliance,
            string? logo,
            long? killFame,
            long? deathFame,
            int? attacksWon,
            int? defensesWon)
        {
            SbiId = sbiId;
            Name = name;
            FounderId = founderId;
            SbiFounderId = sbiFounderId;
            FounderName = founderName;
            Founder = founder;
            Founded = founded;
            AllianceTag = allianceTag;
            AllianceId = allianceId;
            SbiAllianceId = sbiAllianceId;
            AllianceName = allianceName;
            Alliance = alliance;
            Logo = logo;
            KillFame = killFame;
            DeathFame = deathFame;
            AttacksWon = attacksWon;
            DefensesWon = defensesWon;
        }
    }
}
