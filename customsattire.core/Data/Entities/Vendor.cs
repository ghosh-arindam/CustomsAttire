using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Vendor'.
    /// </summary>
    public partial class Vendor
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vendor"/> class.
        /// </summary>
        public Vendor()
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
        /// Gets or sets the property value representing column 'AccountNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AccountNumber'.
        /// </value>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VendorName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VendorName'.
        /// </value>
        public string VendorName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PhoneNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PhoneNumber'.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Address1'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Address1'.
        /// </value>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Address2'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Address2'.
        /// </value>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'City'.
        /// </summary>
        /// <value>
        /// The property value representing column 'City'.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PreferredVendorStatus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PreferredVendorStatus'.
        /// </value>
        public bool? PreferredVendorStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PANNo'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PANNo'.
        /// </value>
        public string PANNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GST'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GST'.
        /// </value>
        public string Gst { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedBy'.
        /// </value>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedDate'.
        /// </value>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedBy'.
        /// </value>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTimeOffset ModifiedDate { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
