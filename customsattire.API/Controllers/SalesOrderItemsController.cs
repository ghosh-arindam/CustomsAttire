using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class SalesOrderItemsController : EntityControllerBase<CustomsAttire.Core.Data.Entities.SalesOrderItems, SalesOrderItemsReadModel, SalesOrderItemsCreateModel, SalesOrderItemsUpdateModel>
    {
        public SalesOrderItemsController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<SalesOrderItemsCreateModel> createValidator, IValidator<SalesOrderItemsUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
