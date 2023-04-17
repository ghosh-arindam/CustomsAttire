using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class SalesOrderItemsUpdateModel
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
        /// Gets or sets the property value for 'BillHeaderId'.
        /// </summary>
        /// <value>
        /// The property value for 'BillHeaderId'.
        /// </value>
        public string BillHeaderId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CustomerName'.
        /// </summary>
        /// <value>
        /// The property value for 'CustomerName'.
        /// </value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FabricCodeId'.
        /// </summary>
        /// <value>
        /// The property value for 'FabricCodeId'.
        /// </value>
        public string FabricCodeId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FabricDesc'.
        /// </summary>
        /// <value>
        /// The property value for 'FabricDesc'.
        /// </value>
        public string FabricDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ClothType'.
        /// </summary>
        /// <value>
        /// The property value for 'ClothType'.
        /// </value>
        public string ClothType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Qty'.
        /// </summary>
        /// <value>
        /// The property value for 'Qty'.
        /// </value>
        public int Qty { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PricePerMeter'.
        /// </summary>
        /// <value>
        /// The property value for 'PricePerMeter'.
        /// </value>
        public decimal PricePerMeter { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FabricDiscount'.
        /// </summary>
        /// <value>
        /// The property value for 'FabricDiscount'.
        /// </value>
        public decimal FabricDiscount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TotalPricePerMeter'.
        /// </summary>
        /// <value>
        /// The property value for 'TotalPricePerMeter'.
        /// </value>
        public decimal TotalPricePerMeter { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StitchingFlag'.
        /// </summary>
        /// <value>
        /// The property value for 'StitchingFlag'.
        /// </value>
        public bool? StitchingFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StitchingCost'.
        /// </summary>
        /// <value>
        /// The property value for 'StitchingCost'.
        /// </value>
        public decimal StitchingCost { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StitchingDiscount'.
        /// </summary>
        /// <value>
        /// The property value for 'StitchingDiscount'.
        /// </value>
        public decimal StitchingDiscount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TotalStitichingCost'.
        /// </summary>
        /// <value>
        /// The property value for 'TotalStitichingCost'.
        /// </value>
        public decimal TotalStitichingCost { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TotalItemwiseCost'.
        /// </summary>
        /// <value>
        /// The property value for 'TotalItemwiseCost'.
        /// </value>
        public decimal? TotalItemwiseCost { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PurchasedItemReturnCost'.
        /// </summary>
        /// <value>
        /// The property value for 'PurchasedItemReturnCost'.
        /// </value>
        public decimal? PurchasedItemReturnCost { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrialDate'.
        /// </summary>
        /// <value>
        /// The property value for 'TrialDate'.
        /// </value>
        public DateTime? TrialDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SchemeFlag'.
        /// </summary>
        /// <value>
        /// The property value for 'SchemeFlag'.
        /// </value>
        public decimal? SchemeFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoyaltySchemeId'.
        /// </summary>
        /// <value>
        /// The property value for 'LoyaltySchemeId'.
        /// </value>
        public int LoyaltySchemeId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RedeemAmount'.
        /// </summary>
        /// <value>
        /// The property value for 'RedeemAmount'.
        /// </value>
        public decimal? RedeemAmount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TotalBillAmount'.
        /// </summary>
        /// <value>
        /// The property value for 'TotalBillAmount'.
        /// </value>
        public decimal? TotalBillAmount { get; set; }

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
        public decimal? DuePayment { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliveryDate'.
        /// </summary>
        /// <value>
        /// The property value for 'DeliveryDate'.
        /// </value>
        public DateTime? DeliveryDate { get; set; }

        #endregion

    }
}
