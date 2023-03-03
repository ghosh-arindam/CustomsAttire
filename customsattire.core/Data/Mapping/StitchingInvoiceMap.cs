using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice" />
    /// </summary>
    public partial class StitchingInvoiceMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.StitchingInvoice>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.StitchingInvoice> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("StitchingInvoice", "Sales");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.StitchingFlag)
                .IsRequired()
                .HasColumnName("Stitching_Flag")
                .HasColumnType("bit");

            builder.Property(t => t.BillHeaderId)
                .HasColumnName("Bill_Header_Id")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SalesItemId)
                .HasColumnName("SalesItem_Id")
                .HasColumnType("int");

            builder.Property(t => t.StitchingTrialDate)
                .IsRequired()
                .HasColumnName("Stitching_Trial_Date")
                .HasColumnType("datetime");

            builder.Property(t => t.StitchingDeliveryDate)
                .HasColumnName("Stitching_Delivery_Date")
                .HasColumnType("datetime");

            builder.Property(t => t.StitchingStatusCode)
                .HasColumnName("Stitching_StatusCode")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice" /></summary>
            public const string Schema = "Sales";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice" /></summary>
            public const string Name = "StitchingInvoice";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.StitchingFlag" /></summary>
            public const string StitchingFlag = "Stitching_Flag";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.BillHeaderId" /></summary>
            public const string BillHeaderId = "Bill_Header_Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.SalesItemId" /></summary>
            public const string SalesItemId = "SalesItem_Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.StitchingTrialDate" /></summary>
            public const string StitchingTrialDate = "Stitching_Trial_Date";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.StitchingDeliveryDate" /></summary>
            public const string StitchingDeliveryDate = "Stitching_Delivery_Date";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.StitchingStatusCode" /></summary>
            public const string StitchingStatusCode = "Stitching_StatusCode";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
