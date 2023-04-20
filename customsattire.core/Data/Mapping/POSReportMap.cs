using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.POSReport" />
    /// </summary>
    public partial class POSReportMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.POSReport>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.POSReport" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.POSReport> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("POSReport", "Production");

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

            builder.Property(t => t.ReportDate)
                .HasColumnName("ReportDate")
                .HasColumnType("date");

            builder.Property(t => t.OpeningCashInHand)
                .IsRequired()
                .HasColumnName("Opening_Cash_in_Hand")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.ExpenseType)
                .IsRequired()
                .HasColumnName("ExpenseType")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ExpenseDescription)
                .IsRequired()
                .HasColumnName("ExpenseDescription")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ExpenseAmount)
                .IsRequired()
                .HasColumnName("ExpenseAmount")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.TotalExpenseAmt)
                .HasColumnName("TotalExpenseAmt")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.CashDepositInBank)
                .IsRequired()
                .HasColumnName("Cash_Deposit_in_Bank")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.MoneyReceivedFromCustomer)
                .IsRequired()
                .HasColumnName("Money_received_from_Customer")
                .HasColumnType("decimal(18,0)");

            builder.Property(t => t.ClosingCashBalance)
                .IsRequired()
                .HasColumnName("Closing_Cash_Balance")
                .HasColumnType("decimal(21,2)")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnName("CreatedDate")
                .HasColumnType("datetimeoffset")
                .HasDefaultValueSql("(sysutcdatetime())");

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetimeoffset")
                .HasDefaultValueSql("(sysutcdatetime())");

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
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.POSReport" /></summary>
            public const string Schema = "Production";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.POSReport" /></summary>
            public const string Name = "POSReport";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.RowId" /></summary>
            public const string RowId = "RowId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.ReportDate" /></summary>
            public const string ReportDate = "ReportDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.OpeningCashInHand" /></summary>
            public const string OpeningCashInHand = "Opening_Cash_in_Hand";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.ExpenseType" /></summary>
            public const string ExpenseType = "ExpenseType";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.ExpenseDescription" /></summary>
            public const string ExpenseDescription = "ExpenseDescription";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.ExpenseAmount" /></summary>
            public const string ExpenseAmount = "ExpenseAmount";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.TotalExpenseAmt" /></summary>
            public const string TotalExpenseAmt = "TotalExpenseAmt";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.CashDepositInBank" /></summary>
            public const string CashDepositInBank = "Cash_Deposit_in_Bank";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.MoneyReceivedFromCustomer" /></summary>
            public const string MoneyReceivedFromCustomer = "Money_received_from_Customer";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.ClosingCashBalance" /></summary>
            public const string ClosingCashBalance = "Closing_Cash_Balance";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.POSReport.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
        }
        #endregion
    }
}
