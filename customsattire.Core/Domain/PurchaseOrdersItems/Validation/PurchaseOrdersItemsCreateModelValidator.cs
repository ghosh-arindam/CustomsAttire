using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="PurchaseOrdersItemsCreateModel"/> .
    /// </summary>
    public partial class PurchaseOrdersItemsCreateModelValidator
        : AbstractValidator<PurchaseOrdersItemsCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrdersItemsCreateModelValidator"/> class.
        /// </summary>
        public PurchaseOrdersItemsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.VendorName).MaximumLength(50);
            RuleFor(p => p.FabricCode).NotEmpty();
            RuleFor(p => p.FabricCode).MaximumLength(100);
            #endregion
        }

    }
}
