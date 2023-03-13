using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class ProductController : EntityControllerBase<CustomsAttire.Core.Data.Entities.Product, ProductReadModel, ProductCreateModel, ProductUpdateModel>
    {
        public ProductController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<ProductCreateModel> createValidator, IValidator<ProductUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
