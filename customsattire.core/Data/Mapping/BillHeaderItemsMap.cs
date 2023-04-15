using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems" />
    /// </summary>
    public partial class BillHeaderItemsMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.BillHeaderItems>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.BillHeaderItems> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Bill_Header_Items", "Sales");

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

            builder.Property(t => t.CustomerPhoneNo)
                .HasColumnName("Customer_phone_no")
                .HasColumnType("int");

            builder.Property(t => t.BillIssueDate)
                .IsRequired()
                .HasColumnName("Bill_Issue_date")
                .HasColumnType("datetime");

            builder.Property(t => t.PaymentDueDate)
                .IsRequired()
                .HasColumnName("Payment_due_date")
                .HasColumnType("datetime");

            builder.Property(t => t.OriginalAmountDue)
                .HasColumnName("Original_Amount_Due")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.AmountOutstanding)
                .HasColumnName("Amount_outstanding")
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
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems" /></summary>
            public const string Schema = "Sales";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems" /></summary>
            public const string Name = "Bill_Header_Items";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.RowId" /></summary>
            public const string RowId = "RowId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.BillHeaderId" /></summary>
            public const string BillHeaderId = "Bill_Header_Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.CustomerPhoneNo" /></summary>
            public const string CustomerPhoneNo = "Customer_phone_no";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.BillIssueDate" /></summary>
            public const string BillIssueDate = "Bill_Issue_date";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.PaymentDueDate" /></summary>
            public const string PaymentDueDate = "Payment_due_date";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.OriginalAmountDue" /></summary>
            public const string OriginalAmountDue = "Original_Amount_Due";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.AmountOutstanding" /></summary>
            public const string AmountOutstanding = "Amount_outstanding";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
