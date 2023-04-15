using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class VendorCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'RowId'.
        /// </summary>
        /// <value>
        /// The property value for 'RowId'.
        /// </value>
        public long RowId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AccountNumber'.
        /// </summary>
        /// <value>
        /// The property value for 'AccountNumber'.
        /// </value>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VendorName'.
        /// </summary>
        /// <value>
        /// The property value for 'VendorName'.
        /// </value>
        public string VendorName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PhoneNumber'.
        /// </summary>
        /// <value>
        /// The property value for 'PhoneNumber'.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Address1'.
        /// </summary>
        /// <value>
        /// The property value for 'Address1'.
        /// </value>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Address2'.
        /// </summary>
        /// <value>
        /// The property value for 'Address2'.
        /// </value>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'City'.
        /// </summary>
        /// <value>
        /// The property value for 'City'.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PreferredVendorStatus'.
        /// </summary>
        /// <value>
        /// The property value for 'PreferredVendorStatus'.
        /// </value>
        public bool? PreferredVendorStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PANNo'.
        /// </summary>
        /// <value>
        /// The property value for 'PANNo'.
        /// </value>
        public string PANNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Gst'.
        /// </summary>
        /// <value>
        /// The property value for 'Gst'.
        /// </value>
        public string Gst { get; set; }

        #endregion

    }
}
