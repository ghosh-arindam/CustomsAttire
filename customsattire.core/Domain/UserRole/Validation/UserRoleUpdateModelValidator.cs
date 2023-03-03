using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="UserRoleUpdateModel"/> .
    /// </summary>
    public partial class UserRoleUpdateModelValidator
        : AbstractValidator<UserRoleUpdateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleUpdateModelValidator"/> class.
        /// </summary>
        public UserRoleUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Role).NotEmpty();
            RuleFor(p => p.Role).MaximumLength(256);
            #endregion
        }

    }
}
