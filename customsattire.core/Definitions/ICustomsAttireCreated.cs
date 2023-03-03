using System;

namespace CustomsAttire.Core.Definitions
{
    public interface ICustomsAttireCreated
    {
        DateTimeOffset CreatedDate { get; set; }
        string? CreatedBy { get; set; }
    }
}
