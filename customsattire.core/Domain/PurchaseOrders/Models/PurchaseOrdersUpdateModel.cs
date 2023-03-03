using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class PurchaseOrdersUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'FabricCode'.
        /// </summary>
        /// <value>
        /// The property value for 'FabricCode'.
        /// </value>
        public string FabricCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'QuantityPurchased'.
        /// </summary>
        /// <value>
        /// The property value for 'QuantityPurchased'.
        /// </value>
        public long QuantityPurchased { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Units'.
        /// </summary>
        /// <value>
        /// The property value for 'Units'.
        /// </value>
        public string Units { get; set; }

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
        /// Gets or sets the property value for 'Paymentmode'.
        /// </summary>
        /// <value>
        /// The property value for 'Paymentmode'.
        /// </value>
        public string Paymentmode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Paymentdone'.
        /// </summary>
        /// <value>
        /// The property value for 'Paymentdone'.
        /// </value>
        public decimal? Paymentdone { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Duepayment'.
        /// </summary>
        /// <value>
        /// The property value for 'Duepayment'.
        /// </value>
        public decimal Duepayment { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Purchasedate'.
        /// </summary>
        /// <value>
        /// The property value for 'Purchasedate'.
        /// </value>
        public DateTime? Purchasedate { get; set; }

        #endregion

    }
}
