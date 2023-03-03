using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="BillHeaderItemsCreateModel"/> .
    /// </summary>
    public partial class BillHeaderItemsCreateModelValidator
        : AbstractValidator<BillHeaderItemsCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillHeaderItemsCreateModelValidator"/> class.
        /// </summary>
        public BillHeaderItemsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BillHeaderId).NotEmpty();
            RuleFor(p => p.BillHeaderId).MaximumLength(255);
            #endregion
        }

    }
}
