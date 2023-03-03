using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class StitchingInvoiceController : EntityControllerBase<CustomsAttire.Core.Data.Entities.StitchingInvoice, StitchingInvoiceReadModel, StitchingInvoiceCreateModel, StitchingInvoiceUpdateModel>
    {
        public StitchingInvoiceController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<StitchingInvoiceCreateModel> createValidator, IValidator<StitchingInvoiceUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
