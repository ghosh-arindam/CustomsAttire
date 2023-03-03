using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="StitchingInvoiceUpdateModel"/> .
    /// </summary>
    public partial class StitchingInvoiceUpdateModelValidator
        : AbstractValidator<StitchingInvoiceUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StitchingInvoiceUpdateModelValidator"/> class.
        /// </summary>
        public StitchingInvoiceUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BillHeaderId).MaximumLength(255);
            RuleFor(p => p.StitchingStatusCode).MaximumLength(255);
            #endregion
        }

    }
}
