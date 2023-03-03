using CustomsAttire.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsAttire.Core.Domain
{
    public class EntityUpdateModel : IHaveIdentifier,ICustomsAttireCreated,ICustomsAttireUpdated
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;

        public string? CreatedBy { get; set; }

        public DateTimeOffset ModifiedDate { get; set; } = DateTimeOffset.UtcNow;

        public string? ModifiedBy { get; set; }

    }
}
