using System;

namespace Eeoe.Restaurant.Entities.Tables.Base
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public string Ekleyen { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public String Duzenleyen { get; set; }
        public DateTime DuzenlenmeTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}