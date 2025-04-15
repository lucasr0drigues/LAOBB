using LAOBB.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Domain.Entities
{
    public class Alliance : EntityBase
    {
        public string SbiAllianceId { get; private set; }
        public string AllianceName { get; private set; }
        public string AllianceTag { get; private set; }
        public string? FounderId { get; private set; }
        public string? SbiFounderId { get; private set; }
        public string? FounderName { get; private set; }
        public Player? Founder { get; private set; }
        public DateTime? Founded { get; private set; }
        public virtual IReadOnlyCollection<Guild> AllianceGuilds => _allianceGuilds;
        private List<Guild> _allianceGuilds = new();
        public int? NumPlayers { get; private set; }

        public Alliance(
            string sbiAllianceId,
            string allianceName,
            string allianceTag,
            string? founderId,
            string? sbiFounderId,
            string? founderName,
            Player? founder,
            DateTime? founded,
            int? numPlayers)
        {
            SbiAllianceId = sbiAllianceId;
            AllianceName = allianceName;
            AllianceTag = allianceTag;
            FounderId = founderId;
            SbiFounderId = sbiFounderId;
            FounderName = founderName;
            Founder = founder;
            Founded = founded;
            NumPlayers = numPlayers;
        }

        public void AddAllianceGuild(Guild guild)
            => _allianceGuilds.Add(guild);

        public void RemoveAllianceGuild(Guild guild)
            => _allianceGuilds.Remove(guild);
    }
}
