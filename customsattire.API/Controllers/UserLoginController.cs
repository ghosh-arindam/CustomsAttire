using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class UserLoginController : QueryControllerBase<Core.Data.Entities.UserLogin, UserLoginReadModel>
    {
        public UserLoginController(CustomsAttireContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }
    }
}
