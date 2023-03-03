using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="Vendor"/> .
    /// </summary>
    public partial class VendorProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorProfile"/> class.
        /// </summary>
        public VendorProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.Vendor, CustomsAttire.Core.Domain.Models.VendorReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.VendorCreateModel, CustomsAttire.Core.Data.Entities.Vendor>();

            CreateMap<CustomsAttire.Core.Data.Entities.Vendor, CustomsAttire.Core.Domain.Models.VendorUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.VendorUpdateModel, CustomsAttire.Core.Data.Entities.Vendor>();

            CreateMap<CustomsAttire.Core.Domain.Models.VendorReadModel, CustomsAttire.Core.Domain.Models.VendorUpdateModel>();

        }

    }
}
