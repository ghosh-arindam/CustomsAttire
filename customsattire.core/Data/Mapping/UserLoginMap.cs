using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.UserLogin" />
    /// </summary>
    public partial class UserLoginMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.UserLogin>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.UserLogin" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.UserLogin> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UserLogin", "Person");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.EmailAddress)
                .IsRequired()
                .HasColumnName("EmailAddress")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.UserAgent)
                .HasColumnName("UserAgent")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Browser)
                .HasColumnName("Browser")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.OperatingSystem)
                .HasColumnName("OperatingSystem")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.DeviceFamily)
                .HasColumnName("DeviceFamily")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.DeviceBrand)
                .HasColumnName("DeviceBrand")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.DeviceModel)
                .HasColumnName("DeviceModel")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.IpAddress)
                .HasColumnName("IpAddress")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IsSuccessful)
                .IsRequired()
                .HasColumnName("IsSuccessful")
                .HasColumnType("bit");

            builder.Property(t => t.FailureMessage)
                .HasColumnName("FailureMessage")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

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
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.UserLogin" /></summary>
            public const string Schema = "Person";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.UserLogin" /></summary>
            public const string Name = "UserLogin";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.EmailAddress" /></summary>
            public const string EmailAddress = "EmailAddress";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.UserId" /></summary>
            public const string UserId = "UserId";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.UserAgent" /></summary>
            public const string UserAgent = "UserAgent";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.Browser" /></summary>
            public const string Browser = "Browser";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.OperatingSystem" /></summary>
            public const string OperatingSystem = "OperatingSystem";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.DeviceFamily" /></summary>
            public const string DeviceFamily = "DeviceFamily";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.DeviceBrand" /></summary>
            public const string DeviceBrand = "DeviceBrand";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.DeviceModel" /></summary>
            public const string DeviceModel = "DeviceModel";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.IpAddress" /></summary>
            public const string IpAddress = "IpAddress";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.IsSuccessful" /></summary>
            public const string IsSuccessful = "IsSuccessful";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.FailureMessage" /></summary>
            public const string FailureMessage = "FailureMessage";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.UserLogin.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
