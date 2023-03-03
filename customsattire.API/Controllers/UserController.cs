using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class UserController : EntityControllerBase<CustomsAttire.Core.Data.Entities.User, UserReadModel, UserCreateModel, UserUpdateModel>
    {
        public UserController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<UserCreateModel> createValidator, IValidator<UserUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
