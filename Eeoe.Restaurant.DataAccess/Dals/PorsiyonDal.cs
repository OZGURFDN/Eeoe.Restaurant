using System.Data.Entity;
using Eeoe.Restaurant.DataAccess.Dals.Base;
using Eeoe.Restaurant.DataAccess.Interfaces;
using Eeoe.Restaurant.Entities.Tables;

namespace Eeoe.Restaurant.DataAccess.Dals
{
    public class PorsiyonDal:Reporsitory<Porsiyon>,IPorsiyonDal
    {
        public PorsiyonDal(DbContext context) : base(context)
        {

        }
    }
}