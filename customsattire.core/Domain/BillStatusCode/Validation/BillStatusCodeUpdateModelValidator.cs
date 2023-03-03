using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="BillStatusCodeUpdateModel"/> .
    /// </summary>
    public partial class BillStatusCodeUpdateModelValidator
        : AbstractValidator<BillStatusCodeUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillStatusCodeUpdateModelValidator"/> class.
        /// </summary>
        public BillStatusCodeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BillStatusCodeMember).MaximumLength(255);
            RuleFor(p => p.BillStatusDescription).NotEmpty();
            RuleFor(p => p.BillStatusDescription).MaximumLength(50);
            #endregion
        }

    }
}
