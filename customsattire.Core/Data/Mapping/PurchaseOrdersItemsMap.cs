using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems" />
    /// </summary>
    public partial class PurchaseOrdersItemsMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.PurchaseOrdersItems>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.PurchaseOrdersItems> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PurchaseOrdersItems", "Purchasing");

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

            builder.Property(t => t.VendorName)
                .HasColumnName("VendorName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FabricCode)
                .IsRequired()
                .HasColumnName("fabricCode")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.FabricDescription)
                .HasColumnName("fabricDescription")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.QuantityPurchased)
                .IsRequired()
                .HasColumnName("quantityPurchased")
                .HasColumnType("decimal(10,2)")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.CostPrice)
                .IsRequired()
                .HasColumnName("costPrice")
                .HasColumnType("decimal(10,2)")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.TotalCostPrice)
                .IsRequired()
                .HasColumnName("totalCostPrice")
                .HasColumnType("decimal(21,4)")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.AdvancePayment)
                .HasColumnName("advancePayment")
                .HasColumnType("decimal(10,2)")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.DuePayment)
                .IsRequired()
                .HasColumnName("duePayment")
                .HasColumnType("decimal(22,4)")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.PurchaseDate)
                .HasColumnName("purchaseDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(((1)/(1))/(1900))");

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("datetimeoffset");

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetimeoffset");

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems" /></summary>
            public const string Schema = "Purchasing";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems" /></summary>
            public const string Name = "PurchaseOrdersItems";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.RowId" /></summary>
            public const string RowId = "RowId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.VendorName" /></summary>
            public const string VendorName = "VendorName";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.FabricCode" /></summary>
            public const string FabricCode = "fabricCode";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.FabricDescription" /></summary>
            public const string FabricDescription = "fabricDescription";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.QuantityPurchased" /></summary>
            public const string QuantityPurchased = "quantityPurchased";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.CostPrice" /></summary>
            public const string CostPrice = "costPrice";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.TotalCostPrice" /></summary>
            public const string TotalCostPrice = "totalCostPrice";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.AdvancePayment" /></summary>
            public const string AdvancePayment = "advancePayment";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.DuePayment" /></summary>
            public const string DuePayment = "duePayment";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.PurchaseDate" /></summary>
            public const string PurchaseDate = "purchaseDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrdersItems.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
