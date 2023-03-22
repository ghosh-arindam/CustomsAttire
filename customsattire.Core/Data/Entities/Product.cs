using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Product'.
    /// </summary>
    public partial class Product
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Id'.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VendorName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VendorName'.
        /// </value>
        public string VendorName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'fabricCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'fabricCode'.
        /// </value>
        public string FabricCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Description'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Description'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedDate'.
        /// </value>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedBy'.
        /// </value>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTimeOffset ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedBy'.
        /// </value>
        public string ModifiedBy { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
