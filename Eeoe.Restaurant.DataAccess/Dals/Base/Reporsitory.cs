using Eeoe.Restaurant.DataAccess.Interfaces.Base;
using Eeoe.Restaurant.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Eeoe.Restaurant.DataAccess.Dals.Base
{
    public class Reporsitory<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private bool disposedValue;

        private readonly DbContext _Context;

        public Reporsitory(DbContext context)
        {
            _Context=context;
        }

        public void Add(TEntity entity)
        {
            _Context.Entry(entity).State = EntityState.Added;
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public BindingList<TEntity> BindingList()
        {
            throw new NotImplementedException();     
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();          
        }

        public void Delete(IEnumerable<TEntity> entities) 
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public bool HasChange()
        {
            throw new NotImplementedException();
        }

        public void Load(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, Expression<Func<TEntity, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
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