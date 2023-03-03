using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class BillHeaderItemsController : EntityControllerBase<CustomsAttire.Core.Data.Entities.BillHeaderItems, BillHeaderItemsReadModel, BillHeaderItemsCreateModel, BillHeaderItemsUpdateModel>
    {
        public BillHeaderItemsController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<BillHeaderItemsCreateModel> createValidator, IValidator<BillHeaderItemsUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
