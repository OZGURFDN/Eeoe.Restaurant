using Eeoe.Restaurant.DataAccess.Interfaces.Base;

namespace Eeoe.Restaurant.DataAccess.UnitOfWork
{
    public class RestaurantUnitOfWork : IUnitOfWork
    {
        private bool disposedValue;

        public bool Commit()
        {
            throw new System.NotImplementedException();
        }

        public bool DetectChanges()
        {
            throw new System.NotImplementedException();
        }

        public bool HasChanges()
        {
            throw new System.NotImplementedException();
        }

        IRepository<TEntity> IUnitOfWork.Dal<TEntity>()
        {
            throw new System.NotImplementedException();
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