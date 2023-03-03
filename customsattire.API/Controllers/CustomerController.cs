using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class CustomerController : EntityControllerBase<CustomsAttire.Core.Data.Entities.Customer, CustomerReadModel, CustomerCreateModel, CustomerUpdateModel>
    {
        public CustomerController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<CustomerCreateModel> createValidator, IValidator<CustomerUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
