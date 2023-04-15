using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class CustomerUpdateModel
        : EntityUpdateModel
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
        /// Gets or sets the property value for 'Title'.
        /// </summary>
        /// <value>
        /// The property value for 'Title'.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FirstName'.
        /// </summary>
        /// <value>
        /// The property value for 'FirstName'.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LastName'.
        /// </summary>
        /// <value>
        /// The property value for 'LastName'.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PhoneNo'.
        /// </summary>
        /// <value>
        /// The property value for 'PhoneNo'.
        /// </value>
        public string PhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EmailId'.
        /// </summary>
        /// <value>
        /// The property value for 'EmailId'.
        /// </value>
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Dob'.
        /// </summary>
        /// <value>
        /// The property value for 'Dob'.
        /// </value>
        public DateTime? Dob { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Gender'.
        /// </summary>
        /// <value>
        /// The property value for 'Gender'.
        /// </value>
        public string Gender { get; set; }

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
        public string Address2 { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the property value for 'AnniversaryDate'.
        /// </summary>
        /// <value>
        /// The property value for 'AnniversaryDate'.
        /// </value>
        public DateTime? anniversaryDate { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Gets or sets the property value for 'AnniversaryDate'.
        /// </summary>
        /// <returns>
        /// The property value for 'AnniversaryDate'.
        /// </returns>
        public DateTime? GetAnniversaryDate()
        {
            return anniversaryDate;
        }

        /// <summary>
        /// Gets or sets the property value for 'AnniversaryDate'.
        /// </summary>
        /// <param name="value">
        /// The property value for 'AnniversaryDate'.
        /// </param>
        public void SetAnniversaryDate(DateTime? value)
        {
            if(anniversaryDate == null )
            {
                anniversaryDate = DateTime.MinValue;
            }
            else
            {
                anniversaryDate = value;
            }

        }

        #endregion

    }
}
