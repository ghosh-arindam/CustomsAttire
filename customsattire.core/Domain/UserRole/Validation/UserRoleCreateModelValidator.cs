using System;
using FluentValidation;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Validation
{
    /// <summary>
    /// Validator class for <see cref="UserRoleCreateModel"/> .
    /// </summary>
    public partial class UserRoleCreateModelValidator
        : AbstractValidator<UserRoleCreateModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleCreateModelValidator"/> class.
        /// </summary>
        public UserRoleCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Role).NotEmpty();
            RuleFor(p => p.Role).MaximumLength(256);
            #endregion
        }

    }
}
