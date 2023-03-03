using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="CustomsAttire.Core.Data.Entities.BillStatusCode" />.
    /// </summary>
    public static partial class BillStatusCodeExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.BillStatusCode"/> or null if not found.</returns>
        public static CustomsAttire.Core.Data.Entities.BillStatusCode GetByKey(this IQueryable<CustomsAttire.Core.Data.Entities.BillStatusCode> queryable, Guid id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<CustomsAttire.Core.Data.Entities.BillStatusCode> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.BillStatusCode"/> or null if not found.</returns>
        public static ValueTask<CustomsAttire.Core.Data.Entities.BillStatusCode> GetByKeyAsync(this IQueryable<CustomsAttire.Core.Data.Entities.BillStatusCode> queryable, Guid id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<CustomsAttire.Core.Data.Entities.BillStatusCode> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<CustomsAttire.Core.Data.Entities.BillStatusCode>(task);
        }

        #endregion

    }
}
