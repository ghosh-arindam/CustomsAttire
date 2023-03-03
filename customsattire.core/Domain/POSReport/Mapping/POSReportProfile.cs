using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="POSReport"/> .
    /// </summary>
    public partial class POSReportProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POSReportProfile"/> class.
        /// </summary>
        public POSReportProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.POSReport, CustomsAttire.Core.Domain.Models.POSReportReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.POSReportCreateModel, CustomsAttire.Core.Data.Entities.POSReport>();

            CreateMap<CustomsAttire.Core.Data.Entities.POSReport, CustomsAttire.Core.Domain.Models.POSReportUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.POSReportUpdateModel, CustomsAttire.Core.Data.Entities.POSReport>();

            CreateMap<CustomsAttire.Core.Domain.Models.POSReportReadModel, CustomsAttire.Core.Domain.Models.POSReportUpdateModel>();

        }

    }
}
