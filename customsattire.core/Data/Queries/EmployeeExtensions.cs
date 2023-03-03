using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.Core.Data.Queries
{
    /// <summary>
    /// Query extensions for entity <see cref="CustomsAttire.Core.Data.Entities.Employee" />.
    /// </summary>
    public static partial class EmployeeExtensions
    {
        #region Generated Extensions
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="businessEntityID">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.Employee"/> or null if not found.</returns>
        public static CustomsAttire.Core.Data.Entities.Employee GetByKey(this IQueryable<CustomsAttire.Core.Data.Entities.Employee> queryable, Guid id, int businessEntityID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<CustomsAttire.Core.Data.Entities.Employee> dbSet)
                return dbSet.Find(id, businessEntityID);

            return queryable.FirstOrDefault(q => q.Id == id
                && q.BusinessEntityID == businessEntityID);
        }

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <param name="queryable">An <see cref="T:System.Linq.IQueryable`1" /> to filter.</param>
        /// <param name="id">The value to filter by.</param>
        /// <param name="businessEntityID">The value to filter by.</param>
        /// <returns>An instance of <see cref="T:CustomsAttire.Core.Data.Entities.Employee"/> or null if not found.</returns>
        public static ValueTask<CustomsAttire.Core.Data.Entities.Employee> GetByKeyAsync(this IQueryable<CustomsAttire.Core.Data.Entities.Employee> queryable, Guid id, int businessEntityID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<CustomsAttire.Core.Data.Entities.Employee> dbSet)
                return dbSet.FindAsync(id, businessEntityID);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id
                && q.BusinessEntityID == businessEntityID);
            return new ValueTask<CustomsAttire.Core.Data.Entities.Employee>(task);
        }

        #endregion

    }
}
