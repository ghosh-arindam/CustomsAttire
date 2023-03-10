using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class EmployeeReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'BusinessEntityID'.
        /// </summary>
        /// <value>
        /// The property value for 'BusinessEntityID'.
        /// </value>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NationalIDNumber'.
        /// </summary>
        /// <value>
        /// The property value for 'NationalIDNumber'.
        /// </value>
        public string NationalIDNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoginID'.
        /// </summary>
        /// <value>
        /// The property value for 'LoginID'.
        /// </value>
        public string LoginID { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'JobTitle'.
        /// </summary>
        /// <value>
        /// The property value for 'JobTitle'.
        /// </value>
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BirthDate'.
        /// </summary>
        /// <value>
        /// The property value for 'BirthDate'.
        /// </value>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaritalStatus'.
        /// </summary>
        /// <value>
        /// The property value for 'MaritalStatus'.
        /// </value>
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Gender'.
        /// </summary>
        /// <value>
        /// The property value for 'Gender'.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HireDate'.
        /// </summary>
        /// <value>
        /// The property value for 'HireDate'.
        /// </value>
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SalariedFlag'.
        /// </summary>
        /// <value>
        /// The property value for 'SalariedFlag'.
        /// </value>
        public bool? SalariedFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VacationHours'.
        /// </summary>
        /// <value>
        /// The property value for 'VacationHours'.
        /// </value>
        public short? VacationHours { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SickLeaveHours'.
        /// </summary>
        /// <value>
        /// The property value for 'SickLeaveHours'.
        /// </value>
        public short? SickLeaveHours { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CurrentFlag'.
        /// </summary>
        /// <value>
        /// The property value for 'CurrentFlag'.
        /// </value>
        public bool? CurrentFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Rowguid'.
        /// </summary>
        /// <value>
        /// The property value for 'Rowguid'.
        /// </value>
        public Guid? Rowguid { get; set; }

        #endregion

    }
}
