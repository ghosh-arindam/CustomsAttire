using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="EmployeeUpdateModel"/> .
    /// </summary>
    public partial class EmployeeUpdateModelValidator
        : AbstractValidator<EmployeeUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeUpdateModelValidator"/> class.
        /// </summary>
        public EmployeeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NationalIDNumber).MaximumLength(20);
            RuleFor(p => p.LoginID).MaximumLength(256);
            RuleFor(p => p.JobTitle).MaximumLength(50);
            RuleFor(p => p.MaritalStatus).MaximumLength(1);
            RuleFor(p => p.Gender).MaximumLength(1);
            #endregion
        }

    }
}
