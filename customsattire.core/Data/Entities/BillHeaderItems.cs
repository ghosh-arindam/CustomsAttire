using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Bill_Header_Items'.
    /// </summary>
    public partial class BillHeaderItems
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillHeaderItems"/> class.
        /// </summary>
        public BillHeaderItems()
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
        /// Gets or sets the property value representing column 'Bill_Header_Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Bill_Header_Id'.
        /// </value>
        public string BillHeaderId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Customer_phone_no'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Customer_phone_no'.
        /// </value>
        public int? CustomerPhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Bill_Issue_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Bill_Issue_date'.
        /// </value>
        public DateTime BillIssueDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Payment_due_date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Payment_due_date'.
        /// </value>
        public DateTime PaymentDueDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Original_Amount_Due'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Original_Amount_Due'.
        /// </value>
        public decimal? OriginalAmountDue { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Amount_outstanding'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Amount_outstanding'.
        /// </value>
        public decimal? AmountOutstanding { get; set; }

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
