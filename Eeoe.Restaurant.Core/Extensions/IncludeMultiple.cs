using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Eeoe.Restaurant.Entities.Interfaces;

namespace Eeoe.Restaurant.Core.Extensions
{
    public static class IncludeMultiple
    {
        //İlişkili Tablo  Sorgusu
        public static IQueryable<TEntity> MultipleInclude<TEntity>(this IQueryable<TEntity> query,
            params Expression<Func<TEntity, object>>[] includes) where TEntity : class, IEntity, new()
        {
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }
    }
}