using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="User"/> .
    /// </summary>
    public partial class UserProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile"/> class.
        /// </summary>
        public UserProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.User, CustomsAttire.Core.Domain.Models.UserReadModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.UserCreateModel, CustomsAttire.Core.Data.Entities.User>();

            CreateMap<CustomsAttire.Core.Data.Entities.User, CustomsAttire.Core.Domain.Models.UserUpdateModel>();

            CreateMap<CustomsAttire.Core.Domain.Models.UserUpdateModel, CustomsAttire.Core.Data.Entities.User>();

            CreateMap<CustomsAttire.Core.Domain.Models.UserReadModel, CustomsAttire.Core.Domain.Models.UserUpdateModel>();

        }

    }
}
