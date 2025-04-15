using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAOBB.Domain.Base
{
    public abstract class EntityBase : IEquatable<EntityBase>
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }

        public bool Equals(EntityBase? other)
        {
            return other != null && Id == other.Id;
        }
    }
}
