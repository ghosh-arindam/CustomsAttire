using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsAttire.Core.Definitions
{
    public interface ICustomsAttireConcurrency
    {
        string RowVersion { get; set; }
    }
}
