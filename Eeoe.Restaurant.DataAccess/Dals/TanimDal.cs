using System.Data.Entity;
using Eeoe.Restaurant.DataAccess.Dals.Base;
using Eeoe.Restaurant.DataAccess.Interfaces;
using Eeoe.Restaurant.Entities.Tables;

namespace Eeoe.Restaurant.DataAccess.Dals
{
    public class TanimDal:Reporsitory<Tanim>,ITanimDal
    {
        public TanimDal(DbContext context) : base(context)
        {
        }
    }
}