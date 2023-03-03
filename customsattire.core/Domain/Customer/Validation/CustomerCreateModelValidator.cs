using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="CustomerCreateModel"/> .
    /// </summary>
    public partial class CustomerCreateModelValidator
        : AbstractValidator<CustomerCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCreateModelValidator"/> class.
        /// </summary>
        public CustomerCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(10);
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.PhoneNo).MaximumLength(25);
            RuleFor(p => p.EmailId).MaximumLength(255);
            RuleFor(p => p.Gender).MaximumLength(1);
            RuleFor(p => p.Address1).MaximumLength(255);
            #endregion
        }

    }
}
