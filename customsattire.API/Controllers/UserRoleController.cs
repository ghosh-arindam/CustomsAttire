using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class UserRoleController : EntityControllerBase<CustomsAttire.Core.Data.Entities.UserRole, UserRoleReadModel, UserRoleCreateModel, UserRoleUpdateModel>
    {
        public UserRoleController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<UserRoleCreateModel> createValidator, IValidator<UserRoleUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
