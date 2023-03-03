using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="EmployeeCreateModel"/> .
    /// </summary>
    public partial class EmployeeCreateModelValidator
        : AbstractValidator<EmployeeCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeCreateModelValidator"/> class.
        /// </summary>
        public EmployeeCreateModelValidator()
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
