using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="PurchaseOrdersUpdateModel"/> .
    /// </summary>
    public partial class PurchaseOrdersUpdateModelValidator
        : AbstractValidator<PurchaseOrdersUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrdersUpdateModelValidator"/> class.
        /// </summary>
        public PurchaseOrdersUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FabricCode).NotEmpty();
            RuleFor(p => p.Units).MaximumLength(50);
            RuleFor(p => p.Paymentmode).MaximumLength(50);
            #endregion
        }

    }
}
