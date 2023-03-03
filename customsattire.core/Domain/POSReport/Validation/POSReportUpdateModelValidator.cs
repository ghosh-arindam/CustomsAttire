using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="POSReportUpdateModel"/> .
    /// </summary>
    public partial class POSReportUpdateModelValidator
        : AbstractValidator<POSReportUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POSReportUpdateModelValidator"/> class.
        /// </summary>
        public POSReportUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ExpenseType).NotEmpty();
            RuleFor(p => p.ExpenseType).MaximumLength(255);
            RuleFor(p => p.ExpenseDescription).NotEmpty();
            RuleFor(p => p.ExpenseDescription).MaximumLength(255);
            #endregion
        }

    }
}
