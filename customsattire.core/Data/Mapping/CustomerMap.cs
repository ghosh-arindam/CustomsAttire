using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.Customer" />
    /// </summary>
    public partial class CustomerMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.Customer>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.Customer" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.Customer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Customer", "Person");

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

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PhoneNo)
                .HasColumnName("PhoneNo")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.EmailId)
                .HasColumnName("EmailId")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Dob)
                .HasColumnName("DOB")
                .HasColumnType("date");

            builder.Property(t => t.Gender)
                .HasColumnName("Gender")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.Address1)
                .HasColumnName("Address1")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Address2)
                .HasColumnName("Address2")
                .HasColumnType("varchar(max)");

            builder.Property(t => t.AnniversaryDate)
                .HasColumnName("AnniversaryDate")
                .HasColumnType("date");

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
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.Customer" /></summary>
            public const string Schema = "Person";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.Customer" /></summary>
            public const string Name = "Customer";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.RowId" /></summary>
            public const string RowId = "RowId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.Title" /></summary>
            public const string Title = "Title";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.FirstName" /></summary>
            public const string FirstName = "FirstName";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.LastName" /></summary>
            public const string LastName = "LastName";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.PhoneNo" /></summary>
            public const string PhoneNo = "PhoneNo";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.EmailId" /></summary>
            public const string EmailId = "EmailId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.Dob" /></summary>
            public const string Dob = "DOB";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.Gender" /></summary>
            public const string Gender = "Gender";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.Address1" /></summary>
            public const string Address1 = "Address1";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.Address2" /></summary>
            public const string Address2 = "Address2";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.AnniversaryDate" /></summary>
            public const string AnniversaryDate = "AnniversaryDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Customer.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
