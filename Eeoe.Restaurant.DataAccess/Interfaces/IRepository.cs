using System;
using System.Collections.Generic;
using Eeoe.Restaurant.Entities.Interfaces;

namespace Eeoe.Restaurant.DataAccess.Interfaces
{
    public interface IRepository<TEntity>:IDisposable where TEntity:class,IEntity,new()
    {
        //Tek Kayıt İçin Oluşturulan Entity
        void Add(TEntity entity);
        //Çoklu Kayıt İçin Oluşturulan Entity overload
        void Add(IEnumerable<TEntity> entities);
        //Ekleme Ve Güncelleme İçin Oluşturulan Entity
        void AddOrUpdate(TEntity entity);
        //Birden Fazla Kayıt Ekleme Ve Güncelleme İçin Oluşturulan Entity
        void AddOrUpdate(IEnumerable<TEntity> entities);
        //Tek Güncelleme İçin Oluşturulan Entity
        void Update(TEntity entity);
        //Birden Fazla  Güncelleme İçin Oluşturulan Entity
        void Update(IEnumerable<TEntity> entities);
        //Tek Güncelleme İçin Oluşturulan Entity
        void Delete(TEntity entity);
        //Birden Fazla  Güncelleme İçin Oluşturulan Entity
        void Delete(IEnumerable<TEntity> entities);





        void Remove(TEntity entity);
        void Remove(IEnumerable<TEntity> entities);
        void RemoveAll();



    }
}
