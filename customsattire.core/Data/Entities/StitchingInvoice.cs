using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'StitchingInvoice'.
    /// </summary>
    public partial class StitchingInvoice
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StitchingInvoice"/> class.
        /// </summary>
        public StitchingInvoice()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Id'.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RowId'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RowId'.
        /// </value>
        public long RowId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Stitching_Flag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Stitching_Flag'.
        /// </value>
        public bool StitchingFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Bill_Header_Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Bill_Header_Id'.
        /// </value>
        public string BillHeaderId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesItem_Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesItem_Id'.
        /// </value>
        public int? SalesItemId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Stitching_Trial_Date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Stitching_Trial_Date'.
        /// </value>
        public DateTime StitchingTrialDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Stitching_Delivery_Date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Stitching_Delivery_Date'.
        /// </value>
        public DateTime? StitchingDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Stitching_StatusCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Stitching_StatusCode'.
        /// </value>
        public string StitchingStatusCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedBy'.
        /// </value>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedDate'.
        /// </value>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedBy'.
        /// </value>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTimeOffset ModifiedDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
