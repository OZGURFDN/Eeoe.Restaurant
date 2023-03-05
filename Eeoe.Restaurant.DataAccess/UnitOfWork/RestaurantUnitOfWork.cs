using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Eeoe.Restaurant.DataAccess.Contexts.Restaurant;
using Eeoe.Restaurant.DataAccess.Dals;
using Eeoe.Restaurant.DataAccess.Dals.Base;
using Eeoe.Restaurant.DataAccess.Interfaces;
using Eeoe.Restaurant.DataAccess.Interfaces.Base;

namespace Eeoe.Restaurant.DataAccess.UnitOfWork
{
    public class RestaurantUnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private readonly RestaurantContext _context;
        public IUrunDal UrunDal { get; set; }
        public ITanimDal TanimDal { get; set; }
        public IPorsiyonDal PorsiyonDal { get; set; }
        public IEkMalzemeDal EkMalzemeDal { get; set; }

        public RestaurantUnitOfWork(RestaurantContext context)
        {
            _context = context;
            UrunDal = new UrunDal(_context);
            TanimDal = new TanimDal(_context);
            PorsiyonDal = new PorsiyonDal(_context);
            EkMalzemeDal = new EkMalzemeDal(_context);

        }

        public bool Commit()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;



            }
        }

        public void DetectChanges()
            {
                _context.ChangeTracker.DetectChanges();

            }

            public bool HasChanges()
            {
                return _context.ChangeTracker.HasChanges();
            }

            IRepository<TEntity> IUnitOfWork.Dal<TEntity>()
        {
                return new Reporsitory<TEntity>(_context);
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
        // ~RestaurantUnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}