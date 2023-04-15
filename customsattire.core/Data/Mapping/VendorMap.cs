using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.Vendor" />
    /// </summary>
    public partial class VendorMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.Vendor>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.Vendor" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.Vendor> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Vendor", "Purchasing");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.RowId)
                .IsRequired()
                .HasColumnName("RowId")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.AccountNumber)
                .HasColumnName("AccountNumber")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.VendorName)
                .HasColumnName("VendorName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.Address1)
                .HasColumnName("Address1")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Address2)
                .HasColumnName("Address2")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.City)
                .HasColumnName("City")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PreferredVendorStatus)
                .HasColumnName("PreferredVendorStatus")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.PANNo)
                .HasColumnName("PANNo")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Gst)
                .HasColumnName("GST")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("datetimeoffset")
                .HasDefaultValueSql("(sysutcdatetime())");

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetimeoffset")
                .HasDefaultValueSql("(sysutcdatetime())");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.Vendor" /></summary>
            public const string Schema = "Purchasing";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.Vendor" /></summary>
            public const string Name = "Vendor";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.RowId" /></summary>
            public const string RowId = "RowId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.AccountNumber" /></summary>
            public const string AccountNumber = "AccountNumber";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.VendorName" /></summary>
            public const string VendorName = "VendorName";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.PhoneNumber" /></summary>
            public const string PhoneNumber = "PhoneNumber";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.Address1" /></summary>
            public const string Address1 = "Address1";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.Address2" /></summary>
            public const string Address2 = "Address2";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.City" /></summary>
            public const string City = "City";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.PreferredVendorStatus" /></summary>
            public const string PreferredVendorStatus = "PreferredVendorStatus";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.PANNo" /></summary>
            public const string PANNo = "PANNo";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.Gst" /></summary>
            public const string Gst = "GST";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Vendor.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
