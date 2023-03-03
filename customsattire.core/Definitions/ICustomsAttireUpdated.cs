using System;

namespace CustomsAttire.Core.Definitions
{
    public interface ICustomsAttireUpdated
    {
        DateTimeOffset ModifiedDate { get; set; }
        string? ModifiedBy { get; set; }
    }
}
