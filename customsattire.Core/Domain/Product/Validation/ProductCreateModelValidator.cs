using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="ProductCreateModel"/> .
    /// </summary>
    public partial class ProductCreateModelValidator
        : AbstractValidator<ProductCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCreateModelValidator"/> class.
        /// </summary>
        public ProductCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FabricCode).MaximumLength(250);
            #endregion
        }

    }
}
