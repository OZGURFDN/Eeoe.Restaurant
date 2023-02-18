using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Eeoe.Restaurant.Entities.Interfaces;

namespace Eeoe.Restaurant.DataAccess.Interfaces.Base
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class, IEntity, new()
    {
        //Tek Kayıt İçin Oluşturulan Entity
        void Add(TEntity entity);
        //Çoklu Kayıt İçin Oluşturulan Entity overload
        void Add(IEnumerable<TEntity> entities);
        //Ekleme Ve Güncelleme İçin Oluşturulan Entity
        void AddOrUpdate(TEntity entity);
        //Birden Fazla Kayıt Ekleme Ve Güncelleme İçin Oluşturulan Entity
        void AddOrUpdate(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);
        void Delete(Expression<Func<TEntity, bool>> filter);
        //Birden Fazla Parametreli Çağırma İşlemi Yapılıyor Params Parametresi ile Mesela Urun Tablosundaki Virtual Tabloları Çağırmak için Tek veri İçin
        TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);
        //Veri Veritabanından varmı ? treu false olarak döndürme işlemi
        bool Exist(Expression<Func<TEntity, bool>> filter);
        //Birden Fazla Parametreli Çağırma İşlemi Yapılıyor Params Parametresi ile Mesela Urun Tablosundaki Virtual Tabloları Çağırmak için Birden Fazla veri İçi
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter,
            Expression<Func<TEntity, object>>[] includes);
        IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, Expression<Func<TEntity, object>>[] include);
        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, object>>[] include);
        void Load(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, object>>[] includes);
        bool HasChange();
        BindingList<TEntity> BindingList();
    }
}