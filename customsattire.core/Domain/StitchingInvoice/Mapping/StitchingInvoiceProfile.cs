using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="StitchingInvoice"/> .
    /// </summary>
    public partial class StitchingInvoiceProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StitchingInvoiceProfile"/> class.
        /// </summary>
        public StitchingInvoiceProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.StitchingInvoice, CustomsAttire.Core.Domain.Models.StitchingInvoiceReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.StitchingInvoiceCreateModel, CustomsAttire.Core.Data.Entities.StitchingInvoice>();

            CreateMap<CustomsAttire.Core.Data.Entities.StitchingInvoice, CustomsAttire.Core.Domain.Models.StitchingInvoiceUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.StitchingInvoiceUpdateModel, CustomsAttire.Core.Data.Entities.StitchingInvoice>();

            CreateMap<CustomsAttire.Core.Domain.Models.StitchingInvoiceReadModel, CustomsAttire.Core.Domain.Models.StitchingInvoiceUpdateModel>();

        }

    }
}
