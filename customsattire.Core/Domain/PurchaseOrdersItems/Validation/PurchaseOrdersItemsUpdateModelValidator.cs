using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="PurchaseOrdersItemsUpdateModel"/> .
    /// </summary>
    public partial class PurchaseOrdersItemsUpdateModelValidator
        : AbstractValidator<PurchaseOrdersItemsUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrdersItemsUpdateModelValidator"/> class.
        /// </summary>
        public PurchaseOrdersItemsUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.VendorName).MaximumLength(50);
            RuleFor(p => p.FabricCode).NotEmpty();
            RuleFor(p => p.FabricCode).MaximumLength(100);
            #endregion
        }

    }
}
