using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PurchaseOrdersItems'.
    /// </summary>
    public partial class PurchaseOrdersItems
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrdersItems"/> class.
        /// </summary>
        public PurchaseOrdersItems()
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
        /// Gets or sets the property value representing column 'VendorName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VendorName'.
        /// </value>
        public string VendorName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'fabricCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'fabricCode'.
        /// </value>
        public string FabricCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'fabricDescription'.
        /// </summary>
        /// <value>
        /// The property value representing column 'fabricDescription'.
        /// </value>
        public string FabricDescription { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'quantityPurchased'.
        /// </summary>
        /// <value>
        /// The property value representing column 'quantityPurchased'.
        /// </value>
        public decimal QuantityPurchased { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'costPrice'.
        /// </summary>
        /// <value>
        /// The property value representing column 'costPrice'.
        /// </value>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'totalCostPrice'.
        /// </summary>
        /// <value>
        /// The property value representing column 'totalCostPrice'.
        /// </value>
        public decimal TotalCostPrice { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'advancePayment'.
        /// </summary>
        /// <value>
        /// The property value representing column 'advancePayment'.
        /// </value>
        public decimal? AdvancePayment { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'duePayment'.
        /// </summary>
        /// <value>
        /// The property value representing column 'duePayment'.
        /// </value>
        public decimal DuePayment { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'purchaseDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'purchaseDate'.
        /// </value>
        public DateTime? PurchaseDate { get; set; }

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
