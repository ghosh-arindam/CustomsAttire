using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="UserRole"/> .
    /// </summary>
    public partial class UserRoleProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleProfile"/> class.
        /// </summary>
        public UserRoleProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.UserRole, CustomsAttire.Core.Domain.Models.UserRoleReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.UserRoleCreateModel, CustomsAttire.Core.Data.Entities.UserRole>();

            CreateMap<CustomsAttire.Core.Data.Entities.UserRole, CustomsAttire.Core.Domain.Models.UserRoleUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.UserRoleUpdateModel, CustomsAttire.Core.Data.Entities.UserRole>();

            CreateMap<CustomsAttire.Core.Domain.Models.UserRoleReadModel, CustomsAttire.Core.Domain.Models.UserRoleUpdateModel>();

        }

    }
}
