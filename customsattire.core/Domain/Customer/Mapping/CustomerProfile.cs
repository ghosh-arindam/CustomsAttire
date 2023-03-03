using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="Customer"/> .
    /// </summary>
    public partial class CustomerProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProfile"/> class.
        /// </summary>
        public CustomerProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.Customer, CustomsAttire.Core.Domain.Models.CustomerReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.CustomerCreateModel, CustomsAttire.Core.Data.Entities.Customer>();

            CreateMap<CustomsAttire.Core.Data.Entities.Customer, CustomsAttire.Core.Domain.Models.CustomerUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.CustomerUpdateModel, CustomsAttire.Core.Data.Entities.Customer>();

            CreateMap<CustomsAttire.Core.Domain.Models.CustomerReadModel, CustomsAttire.Core.Domain.Models.CustomerUpdateModel>();

        }

    }
}
