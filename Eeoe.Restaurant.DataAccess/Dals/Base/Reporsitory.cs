using Eeoe.Restaurant.DataAccess.Interfaces.Base;
using Eeoe.Restaurant.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Eeoe.Restaurant.Core.Extensions;

namespace Eeoe.Restaurant.DataAccess.Dals.Base
{
    public class Reporsitory<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private bool disposedValue;

        private readonly DbContext _context;
        public Reporsitory(DbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }

        public void AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
        }

        public void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Set<TEntity>().AddOrUpdate(entity);
            }
        }
        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filter));
        }

        public bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Any(filter);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _context.Set<TEntity>().MultipleInclude(includes).SingleOrDefault(filter);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null
                ? _context.Set<TEntity>().MultipleInclude(includes).AsNoTracking().ToList()
                : _context.Set<TEntity>().Where(filter).AsNoTracking().ToList();
        }

        public bool HasChange()
        {
            return _context.ChangeTracker.Entries<TEntity>().Any();
        }

        public void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            if (filter == null)
            {
                _context.Set<TEntity>().Load();
            }
            else
            {
                _context.Set<TEntity>().Where(filter).Load();
            }
        }

        public IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter,  Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null
                ? _context.Set<TEntity>().MultipleInclude(includes).Select(selector)
                : _context.Set<TEntity>().MultipleInclude(includes).Where(filter).Select(selector);
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter,  Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null
                ? _context.Set<TEntity>().MultipleInclude(includes).Select(selector)
                : _context.Set<TEntity>().MultipleInclude(includes).Where(filter).Select(selector);
        }

        public BindingList<TEntity> BindingList()
        {
            return _context.Set<TEntity>().Local.ToBindingList();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Reporsitory()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}