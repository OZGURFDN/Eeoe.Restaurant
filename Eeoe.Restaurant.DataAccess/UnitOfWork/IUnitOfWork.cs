using System;
using Eeoe.Restaurant.DataAccess.Interfaces.Base;
using Eeoe.Restaurant.Entities.Interfaces;

namespace Eeoe.Restaurant.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Dal<TEntity>() where TEntity : class,IEntity,new();

        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}