using LAOBB.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Domain.Entities
{
    public class Player : EntityBase
    {
        public string Name { get; private set; }
        public string SbiId { get; private set; }
        public Guid? GuildId { get; private set; }
        public string? GuildName { get; private set; }
        public string? SbiGuildId { get; private set; }
        public Guild? Guild { get; private set; }
        public Guid? AllianceId { get; private set; }
        public string? AllianceName { get; private set; }
        public string? SbiAllianceId { get; private set; }
        public Alliance? Alliance { get; private set; }
        public string? AllianceTag { get; private set; }
        public string? Avatar { get; private set; }
        public string? AvatarRing { get; private set; }
        public int? DeathFame { get; private set; }
        public int? KillFame { get; private set; }
        public double? FameRatio { get; private set; }
        public DateTime? Timestamp { get; private set; }

        public Player(
            string name,
            string sbiId,
            Guild? guild,
            Alliance? alliance,
            string? avatar,
            string? avatarRing,
            int? deathFame,
            int? killFame,
            double? fameRatio,
            DateTime? timestamp)
        {
            Name = name;
            SbiId = sbiId;
            GuildId = guild?.Id;
            GuildName = guild?.Name;
            SbiGuildId = guild?.SbiId;
            Guild = guild;
            AllianceId = alliance?.Id;
            AllianceName = alliance?.AllianceName;
            SbiAllianceId = alliance?.SbiAllianceId;
            Alliance = alliance;
            AllianceTag = alliance?.AllianceTag;
            Avatar = avatar;
            AvatarRing = avatarRing;
            DeathFame = deathFame;
            KillFame = killFame;
            FameRatio = fameRatio;
            Timestamp = timestamp;
        }
    }
}
