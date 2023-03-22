using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="ProductUpdateModel"/> .
    /// </summary>
    public partial class ProductUpdateModelValidator
        : AbstractValidator<ProductUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUpdateModelValidator"/> class.
        /// </summary>
        public ProductUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.VendorName).MaximumLength(50);
            RuleFor(p => p.FabricCode).MaximumLength(250);
            #endregion
        }

    }
}
