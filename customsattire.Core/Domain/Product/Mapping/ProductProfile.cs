using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="Product"/> .
    /// </summary>
    public partial class ProductProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductProfile"/> class.
        /// </summary>
        public ProductProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.Product, CustomsAttire.Core.Domain.Models.ProductReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.ProductCreateModel, CustomsAttire.Core.Data.Entities.Product>();

            CreateMap<CustomsAttire.Core.Data.Entities.Product, CustomsAttire.Core.Domain.Models.ProductUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.ProductUpdateModel, CustomsAttire.Core.Data.Entities.Product>();

            CreateMap<CustomsAttire.Core.Domain.Models.ProductReadModel, CustomsAttire.Core.Domain.Models.ProductUpdateModel>();

        }

    }
}
