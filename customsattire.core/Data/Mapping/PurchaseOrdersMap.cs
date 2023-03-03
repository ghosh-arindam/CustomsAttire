using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders" />
    /// </summary>
    public partial class PurchaseOrdersMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.PurchaseOrders>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.PurchaseOrders> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PurchaseOrders", "Purchasing");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.FabricCode)
                .IsRequired()
                .HasColumnName("fabricCode")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.QuantityPurchased)
                .IsRequired()
                .HasColumnName("quantityPurchased")
                .HasColumnType("bigint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.Units)
                .HasColumnName("units")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CostPrice)
                .IsRequired()
                .HasColumnName("costPrice")
                .HasColumnType("decimal(10,2)")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.TotalCostPrice)
                .IsRequired()
                .HasColumnName("totalCostPrice")
                .HasColumnType("decimal(30,2)")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.Paymentmode)
                .HasColumnName("paymentmode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Paymentdone)
                .HasColumnName("paymentdone")
                .HasColumnType("decimal(10,2)")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.Duepayment)
                .IsRequired()
                .HasColumnName("duepayment")
                .HasColumnType("decimal(31,2)")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.Purchasedate)
                .HasColumnName("purchasedate")
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
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders" /></summary>
            public const string Schema = "Purchasing";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders" /></summary>
            public const string Name = "PurchaseOrders";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.FabricCode" /></summary>
            public const string FabricCode = "fabricCode";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.QuantityPurchased" /></summary>
            public const string QuantityPurchased = "quantityPurchased";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.Units" /></summary>
            public const string Units = "units";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.CostPrice" /></summary>
            public const string CostPrice = "costPrice";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.TotalCostPrice" /></summary>
            public const string TotalCostPrice = "totalCostPrice";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.Paymentmode" /></summary>
            public const string Paymentmode = "paymentmode";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.Paymentdone" /></summary>
            public const string Paymentdone = "paymentdone";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.Duepayment" /></summary>
            public const string Duepayment = "duepayment";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.Purchasedate" /></summary>
            public const string Purchasedate = "purchasedate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
