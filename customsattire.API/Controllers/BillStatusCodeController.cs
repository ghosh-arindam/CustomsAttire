using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class BillStatusCodeController : EntityControllerBase<CustomsAttire.Core.Data.Entities.BillStatusCode, BillStatusCodeReadModel, BillStatusCodeCreateModel, BillStatusCodeUpdateModel>
    {
        public BillStatusCodeController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<BillStatusCodeCreateModel> createValidator, IValidator<BillStatusCodeUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
