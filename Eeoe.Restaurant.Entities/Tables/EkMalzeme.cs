using System;
using Eeoe.Restaurant.Entities.Interfaces;
using Eeoe.Restaurant.Entities.Tables.Base;

namespace Eeoe.Restaurant.Entities.Tables
{
    public class EkMalzeme : EntityBase
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public Guid UrunId { get; set; }
        public virtual Urun Urun { get; set; }
    }
}