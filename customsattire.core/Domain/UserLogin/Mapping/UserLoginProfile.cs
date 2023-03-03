using System;
using AutoMapper;
using CustomsAttire.Core.Data.Entities;
using CustomsAttire.Core.Domain.Models;

namespace CustomsAttire.Core.Domain.Mapping
{
    /// <summary>
    /// Mapper class for entity <see cref="UserLogin"/> .
    /// </summary>
    public partial class UserLoginProfile
        : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLoginProfile"/> class.
        /// </summary>
        public UserLoginProfile()
        {
            CreateMap<CustomsAttire.Core.Data.Entities.UserLogin, CustomsAttire.Core.Domain.Models.UserLoginReadModel>();

        }

    }
}
