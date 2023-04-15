using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class StitchingInvoiceCreateModel
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
        /// Gets or sets the property value for 'StitchingFlag'.
        /// </summary>
        /// <value>
        /// The property value for 'StitchingFlag'.
        /// </value>
        public bool StitchingFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BillHeaderId'.
        /// </summary>
        /// <value>
        /// The property value for 'BillHeaderId'.
        /// </value>
        public string BillHeaderId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SalesItemId'.
        /// </summary>
        /// <value>
        /// The property value for 'SalesItemId'.
        /// </value>
        public int? SalesItemId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StitchingTrialDate'.
        /// </summary>
        /// <value>
        /// The property value for 'StitchingTrialDate'.
        /// </value>
        public DateTime StitchingTrialDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StitchingDeliveryDate'.
        /// </summary>
        /// <value>
        /// The property value for 'StitchingDeliveryDate'.
        /// </value>
        public DateTime? StitchingDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StitchingStatusCode'.
        /// </summary>
        /// <value>
        /// The property value for 'StitchingStatusCode'.
        /// </value>
        public string StitchingStatusCode { get; set; }

        #endregion

    }
}
