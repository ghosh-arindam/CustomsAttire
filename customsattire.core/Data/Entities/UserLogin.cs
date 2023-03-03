using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'UserLogin'.
    /// </summary>
    public partial class UserLogin
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLogin"/> class.
        /// </summary>
        public UserLogin()
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
        /// Gets or sets the property value representing column 'EmailAddress'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmailAddress'.
        /// </value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UserId'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UserId'.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UserAgent'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UserAgent'.
        /// </value>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Browser'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Browser'.
        /// </value>
        public string Browser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OperatingSystem'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OperatingSystem'.
        /// </value>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DeviceFamily'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DeviceFamily'.
        /// </value>
        public string DeviceFamily { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DeviceBrand'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DeviceBrand'.
        /// </value>
        public string DeviceBrand { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DeviceModel'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DeviceModel'.
        /// </value>
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IpAddress'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IpAddress'.
        /// </value>
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IsSuccessful'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IsSuccessful'.
        /// </value>
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FailureMessage'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FailureMessage'.
        /// </value>
        public string FailureMessage { get; set; }

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
