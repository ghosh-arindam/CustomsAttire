using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="VendorUpdateModel"/> .
    /// </summary>
    public partial class VendorUpdateModelValidator
        : AbstractValidator<VendorUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorUpdateModelValidator"/> class.
        /// </summary>
        public VendorUpdateModelValidator()
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
