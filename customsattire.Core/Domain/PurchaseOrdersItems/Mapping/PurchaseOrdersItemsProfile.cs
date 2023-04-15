using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="PurchaseOrdersItems"/> .
    /// </summary>
    public partial class PurchaseOrdersItemsProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrdersItemsProfile"/> class.
        /// </summary>
        public PurchaseOrdersItemsProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.PurchaseOrdersItems, CustomsAttire.Core.Domain.Models.PurchaseOrdersItemsReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.PurchaseOrdersItemsCreateModel, CustomsAttire.Core.Data.Entities.PurchaseOrdersItems>();

            CreateMap<CustomsAttire.Core.Data.Entities.PurchaseOrdersItems, CustomsAttire.Core.Domain.Models.PurchaseOrdersItemsUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.PurchaseOrdersItemsUpdateModel, CustomsAttire.Core.Data.Entities.PurchaseOrdersItems>();

            CreateMap<CustomsAttire.Core.Domain.Models.PurchaseOrdersItemsReadModel, CustomsAttire.Core.Domain.Models.PurchaseOrdersItemsUpdateModel>();

        }

    }
}
