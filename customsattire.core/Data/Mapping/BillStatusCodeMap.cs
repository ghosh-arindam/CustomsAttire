using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode" />
    /// </summary>
    public partial class BillStatusCodeMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.BillStatusCode>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.BillStatusCode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Bill_StatusCode", "Sales");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.BillStatusCodeMember)
                .HasColumnName("Bill_status_code")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.BillStatusDescription)
                .IsRequired()
                .HasColumnName("Bill_status_description")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetimeoffset");

            builder.Property(t => t.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetimeoffset");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode" /></summary>
            public const string Schema = "Sales";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode" /></summary>
            public const string Name = "Bill_StatusCode";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode.BillStatusCodeMember" /></summary>
            public const string BillStatusCodeMember = "Bill_status_code";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode.BillStatusDescription" /></summary>
            public const string BillStatusDescription = "Bill_status_description";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
