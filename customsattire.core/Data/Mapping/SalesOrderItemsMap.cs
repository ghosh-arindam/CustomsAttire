using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems" />
    /// </summary>
    public partial class SalesOrderItemsMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.SalesOrderItems>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.SalesOrderItems> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SalesOrder_Items", "Sales");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.RowId)
                .IsRequired()
                .HasColumnName("RowId")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.BillHeaderId)
                .IsRequired()
                .HasColumnName("Bill_Header_Id")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CustomerName)
                .HasColumnName("CustomerName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FabricCodeId)
                .IsRequired()
                .HasColumnName("FabricCodeId")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FabricDesc)
                .HasColumnName("FabricDesc")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ClothType)
                .IsRequired()
                .HasColumnName("ClothType")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Qty)
                .IsRequired()
                .HasColumnName("Qty")
                .HasColumnType("int");

            builder.Property(t => t.PricePerMeter)
                .IsRequired()
                .HasColumnName("PricePerMeter")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.FabricDiscount)
                .IsRequired()
                .HasColumnName("Fabric_Discount")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.TotalPricePerMeter)
                .IsRequired()
                .HasColumnName("Total_Price_Per_Meter")
                .HasColumnType("decimal(37,8)")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.StitchingFlag)
                .HasColumnName("Stitching_Flag")
                .HasColumnType("bit");

            builder.Property(t => t.StitchingCost)
                .IsRequired()
                .HasColumnName("Stitching_Cost")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.StitchingDiscount)
                .IsRequired()
                .HasColumnName("Stitching_Discount")
                .HasColumnType("decimal(5,2)");

            builder.Property(t => t.TotalStitichingCost)
                .IsRequired()
                .HasColumnName("Total_Stitiching_Cost")
                .HasColumnType("decimal(21,8)")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.TotalItemwiseCost)
                .HasColumnName("Total_ItemwiseCost")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.PurchasedItemReturnCost)
                .HasColumnName("PurchasedItemReturnCost")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.SchemeFlag)
                .HasColumnName("Scheme_Flag")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.LoyaltySchemeId)
                .IsRequired()
                .HasColumnName("Loyalty_Scheme_Id")
                .HasColumnType("int");

            builder.Property(t => t.RedeemAmount)
                .HasColumnName("Redeem_Amount")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.TotalBillAmount)
                .HasColumnName("Total_bill_Amount")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.AdvancePayment)
                .HasColumnName("Advance_Payment")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.DuePayment)
                .HasColumnName("Due_Payment")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("datetimeoffset");

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetimeoffset");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems" /></summary>
            public const string Schema = "Sales";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems" /></summary>
            public const string Name = "SalesOrder_Items";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.RowId" /></summary>
            public const string RowId = "RowId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.BillHeaderId" /></summary>
            public const string BillHeaderId = "Bill_Header_Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.CustomerName" /></summary>
            public const string CustomerName = "CustomerName";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.FabricCodeId" /></summary>
            public const string FabricCodeId = "FabricCodeId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.FabricDesc" /></summary>
            public const string FabricDesc = "FabricDesc";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.ClothType" /></summary>
            public const string ClothType = "ClothType";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.Qty" /></summary>
            public const string Qty = "Qty";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.PricePerMeter" /></summary>
            public const string PricePerMeter = "PricePerMeter";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.FabricDiscount" /></summary>
            public const string FabricDiscount = "Fabric_Discount";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.TotalPricePerMeter" /></summary>
            public const string TotalPricePerMeter = "Total_Price_Per_Meter";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.StitchingFlag" /></summary>
            public const string StitchingFlag = "Stitching_Flag";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.StitchingCost" /></summary>
            public const string StitchingCost = "Stitching_Cost";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.StitchingDiscount" /></summary>
            public const string StitchingDiscount = "Stitching_Discount";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.TotalStitichingCost" /></summary>
            public const string TotalStitichingCost = "Total_Stitiching_Cost";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.TotalItemwiseCost" /></summary>
            public const string TotalItemwiseCost = "Total_ItemwiseCost";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.PurchasedItemReturnCost" /></summary>
            public const string PurchasedItemReturnCost = "PurchasedItemReturnCost";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.SchemeFlag" /></summary>
            public const string SchemeFlag = "Scheme_Flag";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.LoyaltySchemeId" /></summary>
            public const string LoyaltySchemeId = "Loyalty_Scheme_Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.RedeemAmount" /></summary>
            public const string RedeemAmount = "Redeem_Amount";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.TotalBillAmount" /></summary>
            public const string TotalBillAmount = "Total_bill_Amount";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.AdvancePayment" /></summary>
            public const string AdvancePayment = "Advance_Payment";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.DuePayment" /></summary>
            public const string DuePayment = "Due_Payment";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
