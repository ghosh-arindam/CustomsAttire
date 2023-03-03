using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class VendorController : EntityControllerBase<CustomsAttire.Core.Data.Entities.Vendor, VendorReadModel, VendorCreateModel, VendorUpdateModel>
    {
        public VendorController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<VendorCreateModel> createValidator, IValidator<VendorUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
