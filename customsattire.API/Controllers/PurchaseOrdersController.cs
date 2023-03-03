using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class PurchaseOrdersController : EntityControllerBase<CustomsAttire.Core.Data.Entities.PurchaseOrders, PurchaseOrdersReadModel, PurchaseOrdersCreateModel, PurchaseOrdersUpdateModel>
    {
        public PurchaseOrdersController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<PurchaseOrdersCreateModel> createValidator, IValidator<PurchaseOrdersUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
