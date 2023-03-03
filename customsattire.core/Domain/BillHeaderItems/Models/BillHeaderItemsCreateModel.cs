using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class BillHeaderItemsCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'BillHeaderId'.
        /// </summary>
        /// <value>
        /// The property value for 'BillHeaderId'.
        /// </value>
        public string BillHeaderId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CustomerPhoneNo'.
        /// </summary>
        /// <value>
        /// The property value for 'CustomerPhoneNo'.
        /// </value>
        public int? CustomerPhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BillIssueDate'.
        /// </summary>
        /// <value>
        /// The property value for 'BillIssueDate'.
        /// </value>
        public DateTime BillIssueDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PaymentDueDate'.
        /// </summary>
        /// <value>
        /// The property value for 'PaymentDueDate'.
        /// </value>
        public DateTime PaymentDueDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OriginalAmountDue'.
        /// </summary>
        /// <value>
        /// The property value for 'OriginalAmountDue'.
        /// </value>
        public decimal? OriginalAmountDue { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AmountOutstanding'.
        /// </summary>
        /// <value>
        /// The property value for 'AmountOutstanding'.
        /// </value>
        public decimal? AmountOutstanding { get; set; }

        #endregion

    }
}
