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
        public Guid? FounderId { get; private set; }
        public string? SbiFounderId { get; private set; }
        public string? FounderName { get; private set; }
        public Player? Founder { get; private set; }
        public DateTime? Founded { get; private set; }
        public virtual IReadOnlyCollection<Guild> AllianceGuilds => _allianceGuilds;
        private List<Guild> _allianceGuilds = new();
        public int? NumPlayers { get; private set; }

        protected Alliance() { }

        public Alliance(
            string sbiAllianceId,
            string allianceName,
            string allianceTag,
            Player? founder,
            DateTime? founded,
            int? numPlayers)
        {
            SbiAllianceId = sbiAllianceId;
            AllianceName = allianceName;
            AllianceTag = allianceTag;
            FounderId = founder?.Id;
            SbiFounderId = founder?.SbiId;
            FounderName = founder?.Name;
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
