using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="SalesOrderItemsCreateModel"/> .
    /// </summary>
    public partial class SalesOrderItemsCreateModelValidator
        : AbstractValidator<SalesOrderItemsCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderItemsCreateModelValidator"/> class.
        /// </summary>
        public SalesOrderItemsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BillHeaderId).NotEmpty();
            RuleFor(p => p.BillHeaderId).MaximumLength(255);
            RuleFor(p => p.FabricCodeId).NotEmpty();
            RuleFor(p => p.FabricCodeId).MaximumLength(50);
            RuleFor(p => p.ClothType).NotEmpty();
            RuleFor(p => p.ClothType).MaximumLength(50);
            #endregion
        }

    }
}
