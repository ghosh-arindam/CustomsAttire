using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CustomsAttire.Core.Data.Entities.Employee" />
    /// </summary>
    public partial class EmployeeMap
        : IEntityTypeConfiguration<CustomsAttire.Core.Data.Entities.Employee>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CustomsAttire.Core.Data.Entities.Employee" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CustomsAttire.Core.Data.Entities.Employee> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Employee", "HumanResources");

            // key
            builder.HasKey(t => new { t.Id, t.BusinessEntityID });

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.NationalIDNumber)
                .HasColumnName("NationalIDNumber")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.LoginID)
                .HasColumnName("LoginID")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.JobTitle)
                .HasColumnName("JobTitle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("date");

            builder.Property(t => t.MaritalStatus)
                .HasColumnName("MaritalStatus")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.Gender)
                .HasColumnName("Gender")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.HireDate)
                .HasColumnName("HireDate")
                .HasColumnType("date");

            builder.Property(t => t.SalariedFlag)
                .HasColumnName("SalariedFlag")
                .HasColumnType("bit");

            builder.Property(t => t.VacationHours)
                .HasColumnName("VacationHours")
                .HasColumnType("smallint");

            builder.Property(t => t.SickLeaveHours)
                .HasColumnName("SickLeaveHours")
                .HasColumnType("smallint");

            builder.Property(t => t.CurrentFlag)
                .HasColumnName("CurrentFlag")
                .HasColumnType("bit");

            builder.Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .HasColumnType("uniqueidentifier");

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
            /// <summary>Table Schema name constant for entity <see cref="CustomsAttire.Core.Data.Entities.Employee" /></summary>
            public const string Schema = "HumanResources";
            /// <summary>Table Name constant for entity <see cref="CustomsAttire.Core.Data.Entities.Employee" /></summary>
            public const string Name = "Employee";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.BusinessEntityID" /></summary>
            public const string BusinessEntityID = "BusinessEntityID";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.NationalIDNumber" /></summary>
            public const string NationalIDNumber = "NationalIDNumber";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.LoginID" /></summary>
            public const string LoginID = "LoginID";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.JobTitle" /></summary>
            public const string JobTitle = "JobTitle";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.BirthDate" /></summary>
            public const string BirthDate = "BirthDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.MaritalStatus" /></summary>
            public const string MaritalStatus = "MaritalStatus";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.Gender" /></summary>
            public const string Gender = "Gender";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.HireDate" /></summary>
            public const string HireDate = "HireDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.SalariedFlag" /></summary>
            public const string SalariedFlag = "SalariedFlag";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.VacationHours" /></summary>
            public const string VacationHours = "VacationHours";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.SickLeaveHours" /></summary>
            public const string SickLeaveHours = "SickLeaveHours";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.CurrentFlag" /></summary>
            public const string CurrentFlag = "CurrentFlag";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.Rowguid" /></summary>
            public const string Rowguid = "rowguid";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.ModifiedBy" /></summary>
            public const string ModifiedBy = "ModifiedBy";
            /// <summary>Column Name constant for property <see cref="CustomsAttire.Core.Data.Entities.Employee.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
