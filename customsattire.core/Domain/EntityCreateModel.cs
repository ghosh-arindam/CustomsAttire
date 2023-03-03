﻿using CustomsAttire.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsAttire.Core.Domain
{
    public class EntityCreateModel : IHaveIdentifier, ICustomsAttireCreated, ICustomsAttireUpdated
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTimeOffset ModifiedDate { get; set ; }
        public string? ModifiedBy { get ; set ; }
    }
}
