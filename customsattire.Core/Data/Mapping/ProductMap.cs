using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.Product" />
    /// </summary>
    public partial class ProductMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.Product>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.Product" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.Product> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Product", "Purchasing");

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
                .HasColumnName("fabricCode")
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(max)");

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
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.Product" /></summary>
            public const string Schema = "Purchasing";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.Product" /></summary>
            public const string Name = "Product";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.RowId" /></summary>
            public const string RowId = "RowId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.VendorName" /></summary>
            public const string VendorName = "VendorName";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.FabricCode" /></summary>
            public const string FabricCode = "fabricCode";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.Description" /></summary>
            public const string Description = "Description";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Product.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
