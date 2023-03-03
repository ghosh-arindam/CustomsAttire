using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="PurchaseOrders"/> .
    /// </summary>
    public partial class PurchaseOrdersProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrdersProfile"/> class.
        /// </summary>
        public PurchaseOrdersProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.PurchaseOrders, CustomsAttire.Core.Domain.Models.PurchaseOrdersReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.PurchaseOrdersCreateModel, CustomsAttire.Core.Data.Entities.PurchaseOrders>();

            CreateMap<CustomsAttire.Core.Data.Entities.PurchaseOrders, CustomsAttire.Core.Domain.Models.PurchaseOrdersUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.PurchaseOrdersUpdateModel, CustomsAttire.Core.Data.Entities.PurchaseOrders>();

            CreateMap<CustomsAttire.Core.Domain.Models.PurchaseOrdersReadModel, CustomsAttire.Core.Domain.Models.PurchaseOrdersUpdateModel>();

        }

    }
}
