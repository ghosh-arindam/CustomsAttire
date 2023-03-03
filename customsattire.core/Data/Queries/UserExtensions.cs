using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="CustomsAttire.Core.Data.Entities.User" />.
    /// </summary>
    public static partial class UserExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance of <see cref="T:CustomsAttire.Core.Data.Entities.User"/> by using a unique index.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="emailAddress">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.User"/> or null if not found.</returns>
        public static CustomsAttire.Core.Data.Entities.User GetByEmailAddress(this IQueryable<CustomsAttire.Core.Data.Entities.User> queryable, string emailAddress)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.FirstOrDefault(q => q.EmailAddress == emailAddress);
        }

        /// <summary>
        /// Gets an instance of <see cref="T:CustomsAttire.Core.Data.Entities.User"/> by using a unique index.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="emailAddress">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.User"/> or null if not found.</returns>
        public static Task<CustomsAttire.Core.Data.Entities.User> GetByEmailAddressAsync(this IQueryable<CustomsAttire.Core.Data.Entities.User> queryable, string emailAddress)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.FirstOrDefaultAsync(q => q.EmailAddress == emailAddress);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.User"/> or null if not found.</returns>
        public static CustomsAttire.Core.Data.Entities.User GetByKey(this IQueryable<CustomsAttire.Core.Data.Entities.User> queryable, Guid id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<CustomsAttire.Core.Data.Entities.User> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.User"/> or null if not found.</returns>
        public static ValueTask<CustomsAttire.Core.Data.Entities.User> GetByKeyAsync(this IQueryable<CustomsAttire.Core.Data.Entities.User> queryable, Guid id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<CustomsAttire.Core.Data.Entities.User> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CustomsAttire.Core.Data.Entities.User>(task);
        }

        #endregion

    }
}
