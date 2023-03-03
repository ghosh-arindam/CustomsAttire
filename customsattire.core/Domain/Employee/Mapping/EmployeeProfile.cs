using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="Employee"/> .
    /// </summary>
    public partial class EmployeeProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeProfile"/> class.
        /// </summary>
        public EmployeeProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.Employee, CustomsAttire.Core.Domain.Models.EmployeeReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.EmployeeCreateModel, CustomsAttire.Core.Data.Entities.Employee>();

            CreateMap<CustomsAttire.Core.Data.Entities.Employee, CustomsAttire.Core.Domain.Models.EmployeeUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.EmployeeUpdateModel, CustomsAttire.Core.Data.Entities.Employee>();

            CreateMap<CustomsAttire.Core.Domain.Models.EmployeeReadModel, CustomsAttire.Core.Domain.Models.EmployeeUpdateModel>();

        }

    }
}
