using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="PurchaseOrdersCreateModel"/> .
    /// </summary>
    public partial class PurchaseOrdersCreateModelValidator
        : AbstractValidator<PurchaseOrdersCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrdersCreateModelValidator"/> class.
        /// </summary>
        public PurchaseOrdersCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FabricCode).NotEmpty();
            RuleFor(p => p.Units).MaximumLength(50);
            RuleFor(p => p.Paymentmode).MaximumLength(50);
            #endregion
        }

    }
}
