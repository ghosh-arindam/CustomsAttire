using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'User'.
    /// </summary>
    public partial class User
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
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
        /// Gets or sets the property value representing column 'IsEmailAddressConfirmed'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IsEmailAddressConfirmed'.
        /// </value>
        public bool IsEmailAddressConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DisplayName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DisplayName'.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PasswordHash'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PasswordHash'.
        /// </value>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ResetHash'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ResetHash'.
        /// </value>
        public string ResetHash { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'InviteHash'.
        /// </summary>
        /// <value>
        /// The property value representing column 'InviteHash'.
        /// </value>
        public string InviteHash { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AccessFailedCount'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AccessFailedCount'.
        /// </value>
        public int AccessFailedCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LockoutEnabled'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LockoutEnabled'.
        /// </value>
        public bool LockoutEnabled { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LockoutEnd'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LockoutEnd'.
        /// </value>
        public DateTimeOffset? LockoutEnd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LastLogin'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LastLogin'.
        /// </value>
        public DateTimeOffset? LastLogin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IsDeleted'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IsDeleted'.
        /// </value>
        public bool IsDeleted { get; set; }

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
