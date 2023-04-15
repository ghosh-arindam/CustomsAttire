using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class PurchaseOrdersItemsUpdateModel
        : EntityUpdateModel
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
        /// Gets or sets the property value for 'VendorName'.
        /// </summary>
        /// <value>
        /// The property value for 'VendorName'.
        /// </value>
        public string VendorName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FabricCode'.
        /// </summary>
        /// <value>
        /// The property value for 'FabricCode'.
        /// </value>
        public string FabricCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FabricDescription'.
        /// </summary>
        /// <value>
        /// The property value for 'FabricDescription'.
        /// </value>
        public string FabricDescription { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'QuantityPurchased'.
        /// </summary>
        /// <value>
        /// The property value for 'QuantityPurchased'.
        /// </value>
        public decimal QuantityPurchased { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CostPrice'.
        /// </summary>
        /// <value>
        /// The property value for 'CostPrice'.
        /// </value>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TotalCostPrice'.
        /// </summary>
        /// <value>
        /// The property value for 'TotalCostPrice'.
        /// </value>
        public decimal TotalCostPrice { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AdvancePayment'.
        /// </summary>
        /// <value>
        /// The property value for 'AdvancePayment'.
        /// </value>
        public decimal? AdvancePayment { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DuePayment'.
        /// </summary>
        /// <value>
        /// The property value for 'DuePayment'.
        /// </value>
        public decimal DuePayment { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PurchaseDate'.
        /// </summary>
        /// <value>
        /// The property value for 'PurchaseDate'.
        /// </value>
        public DateTime? PurchaseDate { get; set; }

        #endregion

    }
}
