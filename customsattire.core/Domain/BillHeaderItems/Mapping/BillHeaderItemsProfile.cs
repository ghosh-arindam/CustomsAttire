using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="BillHeaderItems"/> .
    /// </summary>
    public partial class BillHeaderItemsProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillHeaderItemsProfile"/> class.
        /// </summary>
        public BillHeaderItemsProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.BillHeaderItems, CustomsAttire.Core.Domain.Models.BillHeaderItemsReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.BillHeaderItemsCreateModel, CustomsAttire.Core.Data.Entities.BillHeaderItems>();

            CreateMap<CustomsAttire.Core.Data.Entities.BillHeaderItems, CustomsAttire.Core.Domain.Models.BillHeaderItemsUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.BillHeaderItemsUpdateModel, CustomsAttire.Core.Data.Entities.BillHeaderItems>();

            CreateMap<CustomsAttire.Core.Domain.Models.BillHeaderItemsReadModel, CustomsAttire.Core.Domain.Models.BillHeaderItemsUpdateModel>();

        }

    }
}
