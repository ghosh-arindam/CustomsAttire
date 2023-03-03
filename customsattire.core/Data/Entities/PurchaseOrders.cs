using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PurchaseOrders'.
    /// </summary>
    public partial class PurchaseOrders
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrders"/> class.
        /// </summary>
        public PurchaseOrders()
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
        /// Gets or sets the property value representing column 'fabricCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'fabricCode'.
        /// </value>
        public string FabricCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'quantityPurchased'.
        /// </summary>
        /// <value>
        /// The property value representing column 'quantityPurchased'.
        /// </value>
        public long QuantityPurchased { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'units'.
        /// </summary>
        /// <value>
        /// The property value representing column 'units'.
        /// </value>
        public string Units { get; set; }

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
        /// Gets or sets the property value representing column 'paymentmode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'paymentmode'.
        /// </value>
        public string Paymentmode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'paymentdone'.
        /// </summary>
        /// <value>
        /// The property value representing column 'paymentdone'.
        /// </value>
        public decimal? Paymentdone { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'duepayment'.
        /// </summary>
        /// <value>
        /// The property value representing column 'duepayment'.
        /// </value>
        public decimal Duepayment { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'purchasedate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'purchasedate'.
        /// </value>
        public DateTime? Purchasedate { get; set; }

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
