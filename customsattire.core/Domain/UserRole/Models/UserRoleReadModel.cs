using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class UserRoleReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'UserId'.
        /// </summary>
        /// <value>
        /// The property value for 'UserId'.
        /// </value>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Role'.
        /// </summary>
        /// <value>
        /// The property value for 'Role'.
        /// </value>
        public string Role { get; set; }

        #endregion

    }
}
