using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="CustomsAttire.Core.Data.Entities.UserRole" />.
    /// </summary>
    public static partial class UserRoleExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="userId">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.UserRole"/> or null if not found.</returns>
        public static CustomsAttire.Core.Data.Entities.UserRole GetByKey(this IQueryable<CustomsAttire.Core.Data.Entities.UserRole> queryable, Guid id, Guid userId)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<CustomsAttire.Core.Data.Entities.UserRole> dbSet)
                return dbSet.Find(id, userId);

            return queryable.FirstOrDefault(q => q.Id == id
                && q.UserId == userId);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="userId">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.UserRole"/> or null if not found.</returns>
        public static ValueTask<CustomsAttire.Core.Data.Entities.UserRole> GetByKeyAsync(this IQueryable<CustomsAttire.Core.Data.Entities.UserRole> queryable, Guid id, Guid userId)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<CustomsAttire.Core.Data.Entities.UserRole> dbSet)
                return dbSet.FindAsync(id, userId);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id
                && q.UserId == userId);
            return new ValueTask<CustomsAttire.Core.Data.Entities.UserRole>(task);
        }

        #endregion

    }
}
