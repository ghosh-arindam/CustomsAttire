using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class ProductCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'FabricCode'.
        /// </summary>
        /// <value>
        /// The property value for 'FabricCode'.
        /// </value>
        public string FabricCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Description'.
        /// </summary>
        /// <value>
        /// The property value for 'Description'.
        /// </value>
        public string Description { get; set; }

        #endregion

    }
}