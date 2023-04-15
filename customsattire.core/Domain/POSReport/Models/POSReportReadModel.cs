using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class POSReportReadModel
        : EntityReadModel
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
        /// Gets or sets the property value for 'ReportDate'.
        /// </summary>
        /// <value>
        /// The property value for 'ReportDate'.
        /// </value>
        public DateTime? ReportDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OpeningCashInHand'.
        /// </summary>
        /// <value>
        /// The property value for 'OpeningCashInHand'.
        /// </value>
        public decimal OpeningCashInHand { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ExpenseType'.
        /// </summary>
        /// <value>
        /// The property value for 'ExpenseType'.
        /// </value>
        public string ExpenseType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ExpenseDescription'.
        /// </summary>
        /// <value>
        /// The property value for 'ExpenseDescription'.
        /// </value>
        public string ExpenseDescription { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ExpenseAmount'.
        /// </summary>
        /// <value>
        /// The property value for 'ExpenseAmount'.
        /// </value>
        public decimal ExpenseAmount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TotalExpenseAmt'.
        /// </summary>
        /// <value>
        /// The property value for 'TotalExpenseAmt'.
        /// </value>
        public decimal? TotalExpenseAmt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CashDepositInBank'.
        /// </summary>
        /// <value>
        /// The property value for 'CashDepositInBank'.
        /// </value>
        public decimal CashDepositInBank { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MoneyReceivedFromCustomer'.
        /// </summary>
        /// <value>
        /// The property value for 'MoneyReceivedFromCustomer'.
        /// </value>
        public decimal MoneyReceivedFromCustomer { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ClosingCashBalance'.
        /// </summary>
        /// <value>
        /// The property value for 'ClosingCashBalance'.
        /// </value>
        public decimal ClosingCashBalance { get; set; }

        #endregion

    }
}
