using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'POSReport'.
    /// </summary>
    public partial class POSReport
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POSReport"/> class.
        /// </summary>
        public POSReport()
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
        /// Gets or sets the property value representing column 'Opening_Cash_in_Hand'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Opening_Cash_in_Hand'.
        /// </value>
        public decimal OpeningCashInHand { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Expense_Type'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Expense_Type'.
        /// </value>
        public string ExpenseType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Expense_Description'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Expense_Description'.
        /// </value>
        public string ExpenseDescription { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Expense_Amt'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Expense_Amt'.
        /// </value>
        public decimal ExpenseAmt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Cash_Deposit_in_Bank'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Cash_Deposit_in_Bank'.
        /// </value>
        public decimal CashDepositInBank { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Money_received_from_Customer'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Money_received_from_Customer'.
        /// </value>
        public decimal MoneyReceivedFromCustomer { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Closing_Cash_Balance'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Closing_Cash_Balance'.
        /// </value>
        public decimal ClosingCashBalance { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedDate'.
        /// </value>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedBy'.
        /// </value>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTimeOffset ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedBy'.
        /// </value>
        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
