using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="BillHeaderItemsUpdateModel"/> .
    /// </summary>
    public partial class BillHeaderItemsUpdateModelValidator
        : AbstractValidator<BillHeaderItemsUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillHeaderItemsUpdateModelValidator"/> class.
        /// </summary>
        public BillHeaderItemsUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BillHeaderId).NotEmpty();
            RuleFor(p => p.BillHeaderId).MaximumLength(255);
            #endregion
        }

    }
}
