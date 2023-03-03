using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="BillStatusCode"/> .
    /// </summary>
    public partial class BillStatusCodeProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillStatusCodeProfile"/> class.
        /// </summary>
        public BillStatusCodeProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.BillStatusCode, CustomsAttire.Core.Domain.Models.BillStatusCodeReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.BillStatusCodeCreateModel, CustomsAttire.Core.Data.Entities.BillStatusCode>();

            CreateMap<CustomsAttire.Core.Data.Entities.BillStatusCode, CustomsAttire.Core.Domain.Models.BillStatusCodeUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.BillStatusCodeUpdateModel, CustomsAttire.Core.Data.Entities.BillStatusCode>();

            CreateMap<CustomsAttire.Core.Domain.Models.BillStatusCodeReadModel, CustomsAttire.Core.Domain.Models.BillStatusCodeUpdateModel>();

        }

    }
}
