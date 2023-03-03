using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="VendorCreateModel"/> .
    /// </summary>
    public partial class VendorCreateModelValidator
        : AbstractValidator<VendorCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorCreateModelValidator"/> class.
        /// </summary>
        public VendorCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.AccountNumber).MaximumLength(50);
            RuleFor(p => p.VendorName).MaximumLength(50);
            RuleFor(p => p.PhoneNumber).MaximumLength(25);
            RuleFor(p => p.Address1).MaximumLength(50);
            RuleFor(p => p.Address2).MaximumLength(50);
            RuleFor(p => p.City).MaximumLength(50);
            RuleFor(p => p.PANNo).MaximumLength(50);
            RuleFor(p => p.Gst).MaximumLength(50);
            #endregion
        }

    }
}
