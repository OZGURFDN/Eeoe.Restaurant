using System.Data.Entity;
using Eeoe.Restaurant.DataAccess.Dals.Base;
using Eeoe.Restaurant.DataAccess.Interfaces;
using Eeoe.Restaurant.Entities.Tables;

namespace Eeoe.Restaurant.DataAccess.Dals
{
    public class UrunDal:Reporsitory<Urun>,IUrunDal
    {
        public UrunDal(DbContext context) : base(context)
        {
        }
    }
}