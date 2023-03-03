using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="StitchingInvoiceCreateModel"/> .
    /// </summary>
    public partial class StitchingInvoiceCreateModelValidator
        : AbstractValidator<StitchingInvoiceCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StitchingInvoiceCreateModelValidator"/> class.
        /// </summary>
        public StitchingInvoiceCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.BillHeaderId).MaximumLength(255);
            RuleFor(p => p.StitchingStatusCode).MaximumLength(255);
            #endregion
        }

    }
}
