using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="BillStatusCodeCreateModel"/> .
    /// </summary>
    public partial class BillStatusCodeCreateModelValidator
        : AbstractValidator<BillStatusCodeCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillStatusCodeCreateModelValidator"/> class.
        /// </summary>
        public BillStatusCodeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BillStatusCodeMember).MaximumLength(255);
            RuleFor(p => p.BillStatusDescription).NotEmpty();
            RuleFor(p => p.BillStatusDescription).MaximumLength(50);
            #endregion
        }

    }
}
