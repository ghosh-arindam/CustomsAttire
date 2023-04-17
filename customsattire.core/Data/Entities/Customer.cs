using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Customer'.
    /// </summary>
    public partial class Customer
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
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
        /// Gets or sets the property value representing column 'RowId'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RowId'.
        /// </value>
        public long RowId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Title'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Title'.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FirstName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FirstName'.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LastName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LastName'.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PhoneNo'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PhoneNo'.
        /// </value>
        public string PhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EmailId'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmailId'.
        /// </value>
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DOB'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DOB'.
        /// </value>
        public DateTime? Dob { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Gender'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Gender'.
        /// </value>
        public string Gender { get; set; }

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
        /// Gets or sets the property value representing column 'AnniversaryDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AnniversaryDate'.
        /// </value>
        public DateTime? AnniversaryDate { get; set; }

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
