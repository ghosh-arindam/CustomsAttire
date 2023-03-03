using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="SalesOrderItems"/> .
    /// </summary>
    public partial class SalesOrderItemsProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderItemsProfile"/> class.
        /// </summary>
        public SalesOrderItemsProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.SalesOrderItems, CustomsAttire.Core.Domain.Models.SalesOrderItemsReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.SalesOrderItemsCreateModel, CustomsAttire.Core.Data.Entities.SalesOrderItems>();

            CreateMap<CustomsAttire.Core.Data.Entities.SalesOrderItems, CustomsAttire.Core.Domain.Models.SalesOrderItemsUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.SalesOrderItemsUpdateModel, CustomsAttire.Core.Data.Entities.SalesOrderItems>();

            CreateMap<CustomsAttire.Core.Domain.Models.SalesOrderItemsReadModel, CustomsAttire.Core.Domain.Models.SalesOrderItemsUpdateModel>();

        }

    }
}
