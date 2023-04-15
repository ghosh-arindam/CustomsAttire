using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class PurchaseOrdersItemsController : EntityControllerBase<CustomsAttire.Core.Data.Entities.PurchaseOrdersItems, PurchaseOrdersItemsReadModel, PurchaseOrdersItemsCreateModel, PurchaseOrdersItemsUpdateModel>
    {
        public PurchaseOrdersItemsController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<PurchaseOrdersItemsCreateModel> createValidator, IValidator<PurchaseOrdersItemsUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
