using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class BillStatusCodeCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'RowId'.
        /// </summary>
        /// <value>
        /// The property value for 'RowId'.
        /// </value>
        public long RowId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BillStatusCodeMember'.
        /// </summary>
        /// <value>
        /// The property value for 'BillStatusCodeMember'.
        /// </value>
        public string BillStatusCodeMember { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BillStatusDescription'.
        /// </summary>
        /// <value>
        /// The property value for 'BillStatusDescription'.
        /// </value>
        public string BillStatusDescription { get; set; }

        #endregion

    }
}
