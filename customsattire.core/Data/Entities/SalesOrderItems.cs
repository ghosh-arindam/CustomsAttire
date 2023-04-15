using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesOrder_Items'.
    /// </summary>
    public partial class SalesOrderItems
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderItems"/> class.
        /// </summary>
        public SalesOrderItems()
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
        /// Gets or sets the property value representing column 'CustomerName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CustomerName'.
        /// </value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FabricCodeId'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FabricCodeId'.
        /// </value>
        public string FabricCodeId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FabricDesc'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FabricDesc'.
        /// </value>
        public string FabricDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ClothType'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ClothType'.
        /// </value>
        public string ClothType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Qty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Qty'.
        /// </value>
        public int Qty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PricePerMeter'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PricePerMeter'.
        /// </value>
        public decimal PricePerMeter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Fabric_Discount'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Fabric_Discount'.
        /// </value>
        public decimal FabricDiscount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Total_Price_Per_Meter'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Total_Price_Per_Meter'.
        /// </value>
        public decimal TotalPricePerMeter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Stitching_Flag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Stitching_Flag'.
        /// </value>
        public bool? StitchingFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Stitching_Cost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Stitching_Cost'.
        /// </value>
        public decimal StitchingCost { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Stitching_Discount'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Stitching_Discount'.
        /// </value>
        public decimal StitchingDiscount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Total_Stitiching_Cost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Total_Stitiching_Cost'.
        /// </value>
        public decimal TotalStitichingCost { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Total_ItemwiseCost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Total_ItemwiseCost'.
        /// </value>
        public decimal? TotalItemwiseCost { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PurchasedItemReturnCost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PurchasedItemReturnCost'.
        /// </value>
        public decimal? PurchasedItemReturnCost { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Scheme_Flag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Scheme_Flag'.
        /// </value>
        public decimal? SchemeFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Loyalty_Scheme_Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Loyalty_Scheme_Id'.
        /// </value>
        public int LoyaltySchemeId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Redeem_Amount'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Redeem_Amount'.
        /// </value>
        public decimal? RedeemAmount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Total_bill_Amount'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Total_bill_Amount'.
        /// </value>
        public decimal? TotalBillAmount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Advance_Payment'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Advance_Payment'.
        /// </value>
        public decimal? AdvancePayment { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Due_Payment'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Due_Payment'.
        /// </value>
        public decimal? DuePayment { get; set; }

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
