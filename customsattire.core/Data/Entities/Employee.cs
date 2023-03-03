using System;
using System.Collections.Generic;

namespace CustomsAttire.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Employee'.
    /// </summary>
    public partial class Employee
        : Definitions.IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BusinessEntityID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BusinessEntityID'.
        /// </value>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NationalIDNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NationalIDNumber'.
        /// </value>
        public string NationalIDNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LoginID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LoginID'.
        /// </value>
        public string LoginID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'JobTitle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'JobTitle'.
        /// </value>
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BirthDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BirthDate'.
        /// </value>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MaritalStatus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MaritalStatus'.
        /// </value>
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Gender'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Gender'.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HireDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HireDate'.
        /// </value>
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalariedFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalariedFlag'.
        /// </value>
        public bool? SalariedFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VacationHours'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VacationHours'.
        /// </value>
        public short? VacationHours { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SickLeaveHours'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SickLeaveHours'.
        /// </value>
        public short? SickLeaveHours { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CurrentFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CurrentFlag'.
        /// </value>
        public bool? CurrentFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public Guid? Rowguid { get; set; }

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
