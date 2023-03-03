using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CustomsAttire.Core.Data
{
    /// <summary>
    /// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities. 
    /// </summary>
    public partial class CustomsAttireContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsAttireContext"/> class.
        /// </summary>
        /// <param name="options">The options to be used by this <see cref="DbContext" />.</param>
        public CustomsAttireContext(DbContextOptions<CustomsAttireContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.BillHeaderItems"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.BillHeaderItems> BillHeaderItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.BillStatusCode> BillStatusCodes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.Customer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.Customer"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.Employee"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.Employee"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.POSReport"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.POSReport"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.POSReport> POSReports { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.PurchaseOrders"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.PurchaseOrders> PurchaseOrders { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.SalesOrderItems"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.SalesOrderItems> SalesOrderItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.StitchingInvoice"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.StitchingInvoice> StitchingInvoices { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.UserLogin"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.UserLogin"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.UserLogin> UserLogins { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.UserRole"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.UserRole"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.UserRole> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.User"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.User"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.User> Users { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.Vendor"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CustomsAttire.Core.Data.Entities.Vendor"/>.
        /// </value>
        public virtual DbSet<CustomsAttire.Core.Data.Entities.Vendor> Vendors { get; set; }

        #endregion

        /// <summary>
        /// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.BillHeaderItemsMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.BillStatusCodeMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.CustomerMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.EmployeeMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.POSReportMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.PurchaseOrdersMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.SalesOrderItemsMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.StitchingInvoiceMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.UserLoginMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.UserMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.UserRoleMap());
            modelBuilder.ApplyConfiguration(new CustomsAttire.Core.Data.Mapping.VendorMap());
            #endregion
        }
    }
}
